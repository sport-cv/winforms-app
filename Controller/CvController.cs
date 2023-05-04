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
            _mainView.EditCv += EditCV;
        }

        private void EditCV(string name)
        {
            _view = CreateCvView();
            _mainView.Hide();
            _view.Show();
            _model.LoadCvToEdit(name);
        }

        private void BackToMainScreen()
        {
            _view.Hide();
            _mainView.Show();
            _mainView.RefreshCVList();
        }

        private void NewCv()
        {
            _view = CreateCvView();
            _mainView.Hide();
            _view.Show();
        }

        private CvView CreateCvView()
        {
            var view = new CvView();

            // TODO: must remove other subscription
            _model.CvWasSavedWithSuccess += view.AlertCvSaved;
            _model.CvToEditLoaded += view.UpdateCvFormControls;

            view.BackToMainScreen += BackToMainScreen;
            view.SaveCv += _model.SaveCv;
            view.LoadCvToEdit += _model.GetCvToEdit;

            return view;
        }

    }
}
