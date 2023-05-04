using SportCv.Entities;
using SportCv.Models;
using SportCv.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Controller
{
    public class PdfController
    {
        private PdfView _view;
        private PdfModel _model;
        private MainView _mainView;
        private CvView _cvView;

        public PdfController(PdfView view, PdfModel model, MainView mainView, CvView cvView)
        {
            _view = view;
            _model = model;
            _mainView = mainView;
            _cvView = cvView;

            _view.OnExport += _model.ExportCvToPdf;
            _view.OnExit += ExitView;
            _model.OnPdfSaved += _view.SaveAlert;

            _cvView.OnExportToPdf += ExportToPdf;
            _mainView.OnExportAllToPdf += ExportAllToPdf;
        }

        private void ExitView(bool backToMainScreen)
        {
            _view.Hide();

            if(backToMainScreen)
            {
                _mainView.Show();
            }
            else
            {
                _cvView.Show();
            }
        }

        private void ExportAllToPdf(IEnumerable<string> idsToExport)
        {
            _view.IsMultipleFilesExport = true;
            _view.CvIdsToExport = idsToExport;
            _mainView.Hide();
            _view.Show();
        }

        private void ExportToPdf(string idToExport)
        {
            _view.IsMultipleFilesExport = false;
            _view.CvIdsToExport = new [] { idToExport };
            _cvView.Hide();
            _view.Show();
        }

        
    }


}
