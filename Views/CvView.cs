using SportCv.Enitities;
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
        public event Action BackToMainScreen;

        public delegate void SaveCvHandler(Cv cv);
        public event SaveCvHandler SaveCv;

        public delegate Cv LoadCvToEditHandler();
        public event LoadCvToEditHandler LoadCvToEdit;

        public event Action ExportToPdf;

        public CvView()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToMainScreen();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            BackToMainScreen();
        }

        private void SaveCvButton_Click(object sender, EventArgs e)
        {
            var cv = new Cv
            {
                Name = NameTextbox.Text,
                Email = EmailTextbox.Text
            };

            SaveCv(cv);
        }

        public void AlertCvSaved()
        {
            // TODO: Remove alert after 5sec
            AlertLabel.Text = "O CV foi gravado com sucesso.";
        }

        public void UpdateCvFormControls()
        {
            var cv = LoadCvToEdit();

            NameTextbox.Text = cv.Name;
            EmailTextbox.Text = cv.Email;
        }
        private void ExportToPdfButton_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }
    }
}
