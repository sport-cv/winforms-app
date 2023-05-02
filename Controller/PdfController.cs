using SportCv.Models;
using SportCv.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Controller
{
    public class PdfController
    {
        private MainView _mainView;
        private PdfView _view;
        private PdfModel _model;

        public PdfController(MainView mainView, PdfModel model)
        {
            _mainView = mainView;
            _mainView.ExportToPdf += ExportToPdf;
            _model = model;
        }

        private void ExportAllToPdf(string filePath, string clubName)
        {
            _model.Export(filePath, clubName);
        }

        private void ExportToPdf()
        {
            _view = new PdfView();
            _mainView.Hide();
            _view.ExportAllToPdf += ExportAllToPdf;
            _view.Show();
        }
    }


}
