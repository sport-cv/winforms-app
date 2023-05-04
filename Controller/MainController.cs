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
        private MainView _view;
        private JsonModel _jsonModel;

        public MainController(MainView view, JsonModel jsonModel)
        {
            _view = view;
            _jsonModel = jsonModel;

            _jsonModel.OnFileLoaded += _view.RefreshCvListbox;
            _jsonModel.OnFileSaved += _view.SaveFileAlert;

            _view.OnFileOpen += _jsonModel.ReadFile;
            _view.OnFileSave += _jsonModel.WriteFile;
        }

        public void Execute()
        {
            _view.Show();
        }
    }
}
