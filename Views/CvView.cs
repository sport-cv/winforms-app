using SportCv.Controllers;
using SportCv.Entities;
using SportCv.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Views
{

    public partial class CvView : Form
    {
        private CvModel _cvModel;
        private IList<IExperience>  _history;

        public delegate void SaveCvHandler(Cv cv);
        public event SaveCvHandler OnSaveCv;

        public event Action OnExit;

        public delegate void ExportToPdfHandler(string idToExport);
        public event ExportToPdfHandler OnExportToPdf;

        public delegate void EditExperienceHandle(IExperience experience);
        public event EditExperienceHandle OnEditExperience;

        public delegate void NewExperienceHandler(IExperience type);
        public NewExperienceHandler OnNewExperience;

        public CvView(CvModel cvModel)
        {
            InitializeComponent();
            _cvModel = cvModel;
            _history = new List<IExperience>();
        }

        private void SaveCvButton_Click(object sender, EventArgs e)
        {
            var cv = new Cv
            {
                Name = NameTextbox.Text,
                Email = EmailTextbox.Text,
                History = _history
            };

            OnSaveCv(cv);
        }

        private void ExportToPdfButton_Click(object sender, EventArgs e)
        {
            OnExportToPdf(NameTextbox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnExit();
        }

        public void RefreshControls(string cvId)
        {
            var cv = _cvModel.GetCv(cvId);

            _history = cv.History.ToList();

            NameTextbox.Text = cv.Name;
            EmailTextbox.Text = cv.Email;

            RefreshExperience();
        }

        public void ClearControls()
        {
            NameTextbox.Text = "";
            EmailTextbox.Text = "";
            HistoryListView.Items.Clear();
        }

        public void SaveAlert()
        {
            MessageBox.Show("CV foi guardado com sucesso!");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                OnExit();
            }
        }

        private void HistoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HistoryListView.SelectedItems.Count == 0)
            {
                return;
            }

            OnEditExperience(_history[HistoryListView.SelectedItems[0].Index]);
        }

        public void RefreshExperience()
        {
            var historyListViewItems = _history.Select(exp => exp.ToListViewItem());
            HistoryListView.Items.Clear();
            HistoryListView.Items.AddRange(historyListViewItems.ToArray());
        }

        private void AddHistoryButton_Click(object sender, EventArgs e)
        {
            IExperience experience = null;
            foreach (var item in this.Controls.OfType<RadioButton>())
            {
                if(!item.Checked)
                {
                    continue;
                }

                switch (item.Name)
                {
                    case var name when name.StartsWith("Player"):
                        experience = new PlayerExperience();
                        break;
                    case var name when name.StartsWith("Coach"):
                        experience = new CoachExperience();
                        break;
                    case var name when name.StartsWith("Staff"):
                        experience = new StaffExperience();
                        break;
                    default:
                        break;
                }
                break;
            }

            if (experience != null) {
                _history.Add(experience);
                OnNewExperience(experience);
            }
        }
    }
}
