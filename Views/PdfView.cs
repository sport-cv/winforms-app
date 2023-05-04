using SportCv.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Views
{
    public partial class PdfView : Form
    {
        public delegate void ExportToPdfHandler(IEnumerable<string> idsToExport, Header header, string path);
        public event ExportToPdfHandler OnExport;

        public delegate void OnExitHandler(bool backToMainScreen);
        public event OnExitHandler OnExit;
        public PdfView()
        {
            InitializeComponent();
        }

        public bool IsMultipleFilesExport { get; set; }
        public IEnumerable<string> CvIdsToExport { get; set; }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var path = GetPathFromDialog(IsMultipleFilesExport);
            
            if (path == null)
            { 
                return;
            }

            var header = new Header { 
                ClubName = ClubNameTextbox.Text,
                Season = SeasonTextbox.Text
            };

            OnExport(CvIdsToExport, header, path);
        }

        private string GetPathFromDialog(bool isfolderDialog)
        {
            CommonDialog dialog;

            if (isfolderDialog)
            {
                dialog = new FolderBrowserDialog
                {
                    Description = "Escolha uma pasta para exportar todos os ficheiros"
                };
            }
            else
            {
                dialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Guardar Ficheiro JSON"
                };
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return isfolderDialog ?
                    ((FolderBrowserDialog)dialog).SelectedPath : 
                    ((SaveFileDialog)dialog).FileName;
            }


            return null;
        }

        public void SaveAlert()
        {
            MessageBox.Show(IsMultipleFilesExport ? 
                "Todos os CVs foram gravados com sucesso" : 
                "O CV foi gravado com sucesso");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                ExitButton_Click(this, EventArgs.Empty);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            OnExit(IsMultipleFilesExport);
        }
    }
}
