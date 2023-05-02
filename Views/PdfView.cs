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
    public partial class PdfView : Form
    {
        public delegate void ExportAllToPdfHandler(string filePath, string clubName);
        public event ExportAllToPdfHandler ExportAllToPdf;
        public PdfView()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog
            {
                Description = "Escolha uma pasta para exportar todos os ficheiros"
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                ExportAllToPdf(folderDialog.SelectedPath, ClubNameTextBox.Text);
            }
        }
    }
}
