using SportCv.Entities;
using SportCv.Models;
using SportCv.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Controllers
{
    public class CvController
    {
        private CvView _view;
        private CvModel _model;
        private MainView _mainView;
        private ExperienceView _experienceView;

        public CvController(CvView view, CvModel model, MainView mainView, ExperienceView experienceView)
        {
            _view = view;
            _model = model;
            _mainView = mainView;
            _experienceView = experienceView;

            _view.OnSaveCv += _model.SaveCv;
            _view.OnExit += HideView;
            _view.OnEditExperience += EditExperience;
            _view.OnNewExperience += EditExperience;
            
            _model.OnSaveSuccess += _view.SaveAlert;

            _mainView.OnEditCv += EditCv;
            _mainView.OnNewCv += NewCv;

            _experienceView.OnExperienceUpdated += _view.RefreshExperience;
        }

        private void EditExperience(IExperience experience)
        {
            _experienceView.Refresh(experience);
            OpenExperienceView();
        }

        private void OpenExperienceView()
        {
            _experienceView.Show();
            _experienceView.Location = new System.Drawing.Point(_view.Location.X + _view.Width, _view.Location.Y);
            _experienceView.Focus();
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
            _experienceView.Hide();
            _mainView.RefreshCvListbox();
            _mainView.Show();
        }
    }
}
