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

        public CvController(MainView mainView)
        {
            _mainView = mainView;
            _mainView.NewCv += NewCv;
        }

        private void NewCv()
        {
            MessageBox.Show("Run New CV event");
        }

    }
}
