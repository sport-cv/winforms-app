using SportCv.Entities;
using SportCv.Models;
using System;
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

        public delegate void SaveCvHandler(Cv cv);
        public event SaveCvHandler OnSaveCv;

        public event Action OnExit;

        public delegate void EditExperienceHandler(string season);
        public event EditExperienceHandler OnEditExperience;

        public delegate void ExportToPdfHandler(string idToExport);
        public event ExportToPdfHandler OnExportToPdf;

        public CvView(CvModel cvModel)
        {
            InitializeComponent();
            _cvModel = cvModel;
        }

        private void SaveCvButton_Click(object sender, EventArgs e)
        {
            var cv = new Cv
            {
                Name = NameTextbox.Text,
                Email = EmailTextbox.Text
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
            
            NameTextbox.Text = cv.Name;
            EmailTextbox.Text = cv.Email;
            var historyListViewItems = cv.History.Select(exp => exp.ConvertToListViewItem());
            HistoryListView.Items.AddRange(historyListViewItems.ToArray());
        }

        public void ClearControls()
        {
            NameTextbox.Text = "";
            EmailTextbox.Text = "";
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
            MessageBox.Show(HistoryListView.SelectedItems[0].Text);
        }
    }
}
