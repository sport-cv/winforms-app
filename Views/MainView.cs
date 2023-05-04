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
    public partial class MainView : Form
    {
        private readonly CvModel _cvModel;

        public delegate void FileOpenHandler(string fileName);
        public event FileOpenHandler OnFileOpen;

        public delegate void FileSaveHandler(string fileName);
        public event FileSaveHandler OnFileSave;

        public delegate void EditCvHandler(string cvId);
        public event EditCvHandler OnEditCv;

        public delegate void ExportAllToPdfHandler(IEnumerable<string> idsToExport);
        public ExportAllToPdfHandler OnExportAllToPdf;

        public Action OnNewCv;

        public MainView(CvModel cvModel)
        {
            InitializeComponent();
            _cvModel = cvModel;
        }

        public void RefreshCvListbox()
        {
            var cvList = _cvModel.GetAllCvs();
            CvListbox.Items.Clear();
            
            foreach (var cv in cvList)
            {
                CvListbox.Items.Add($"{cv.Name}");
            }
        }

        public void SaveFileAlert()
        {
            MessageBox.Show("O ficheiro foi gravado com sucesso.");
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog =new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                Title = "Abrir Ficheiro JSON"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK )
            {
                OnFileOpen(openFileDialog.FileName);
            }
        }

        private void NewCvButton_Click(object sender, EventArgs e)
        {
            OnNewCv();
        }
        private void EditCVButton_Click(object sender, EventArgs e)
        {
            OnEditCv(CvListbox.SelectedItem.ToString());
        }
        private void ExportToPdfButton_Click(object sender, EventArgs e)
        {
            var idsToExport = new string[CvListbox.Items.Count];
            CvListbox.Items.CopyTo(idsToExport, 0);
            OnExportAllToPdf(idsToExport);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                Title = "Guardar Ficheiro JSON"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OnFileSave(saveFileDialog.FileName);
            }
        }
    }
}
