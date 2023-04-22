using SportCv.Enitities;
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
        public delegate IEnumerable<Cv> LoadCvListHandler();
        public event LoadCvListHandler LoadCvList;

        public delegate void OpenFileHandler(string filePath);
        public event OpenFileHandler OpenFile;

        public MainView()
        {
            InitializeComponent();
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
                OpenFile(openFileDialog.FileName);
            }
        }

        public void RefreshCVList()
        {
            CvListbox.Items.Clear();
            var cvList = LoadCvList();

            foreach (var cv in cvList)
            {
                CvListbox.Items.Add($"{cv.Name}");
            }     
        }
    }
}
