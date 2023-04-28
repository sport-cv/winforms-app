using SportCv.Models;
using SportCv.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Controller
{
    public class MainController
    {
        private MainView _mainView;
        private FileModel _fileModel;
        private CvModel _cvModel;

        public MainController(MainView mainView, FileModel fileModel, CvModel cvModel)
        {
            _mainView = mainView;
            _fileModel = fileModel;
            _cvModel = cvModel;

            _mainView.OpenFile += OpenFile;
            _mainView.LoadCvList += _cvModel.GetCvList;

            _fileModel.FileLoaded += _mainView.RefreshCVList;
        }

        public void Execute()
        {
            _mainView.Show();
        }

        private void OpenFile(string filePath)
        {
            _fileModel.ReadFile(filePath);
        }
    }
}
