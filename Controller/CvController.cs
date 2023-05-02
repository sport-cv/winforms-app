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
    public class CvController
    {
        private MainView _mainView;
        private CvView _view;
        private CvModel _model;

        public CvController(MainView mainView, CvModel model)
        {
            _mainView = mainView;
            _model = model;

            _mainView.NewCv += NewCv;
        }

        private void BackToMainScreen()
        {
            _view.Hide();
            _mainView.Show();
            _mainView.RefreshCVList();
        }

        private void NewCv()
        {
            _view = new CvView();
            
            // TODO: must remove other subscription
            _model.CvWasSavedWithSuccess += _view.AlertCvSaved;
         
            _view.BackToMainScreen += BackToMainScreen;
            _view.SaveCv += _model.SaveCv;
            
            _mainView.Hide();
            _view.Show();
        }

    }
}
