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
        private CvView _cvView;

        public CvController(MainView mainView, CvView cvView)
        {
            _mainView = mainView;
            _mainView.NewCv += NewCv;
            
            _cvView = cvView;
            _cvView.BackToMainScreen += BackToMainScreen;
        }

        private void BackToMainScreen()
        {
            _cvView.Hide();
            _mainView.Show();
        }

        private void NewCv()
        {
            _mainView.Hide();

            if(_cvView.IsDisposed)
            {
                _cvView = new CvView();
                _cvView.BackToMainScreen += BackToMainScreen;
            }

            _cvView.Show();
        }

    }
}
