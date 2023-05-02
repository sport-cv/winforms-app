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

        public PdfController(MainView mainView)
        {
            _mainView = mainView;
            _mainView.ExportToPdf += ExportToPdf;
        }

        private void ExportToPdf()
        {
            _view = new PdfView();
            _mainView.Hide();
            _view.Show();
        }
    }


}
