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
    public class CvController
    {
        private CvView _view;
        private CvModel _model;
        private MainView _mainView;

        public CvController(CvView view, CvModel model, MainView mainView)
        {
            _view = view;
            _model = model;
            _mainView = mainView;

            _view.OnSaveCv += _model.SaveCv;
            _view.OnExit += HideView;

            _model.OnSaveSuccess += _view.SaveAlert;

            _mainView.OnEditCv += EditCv;
            _mainView.OnNewCv += NewCv;
        }

        private void EditCv(string cvId)
        {
            _view.RefreshControls(cvId);
            ShowView();
        }

        private void NewCv()
        {
            _view.ClearControls();
            ShowView();
        }

        private void ShowView() 
        {
            _mainView.Hide();
            _view.Show();
        }

        private void HideView()
        {
            _view.Hide();
            _mainView.RefreshCvListbox();
            _mainView.Show();
        }
    }
}
