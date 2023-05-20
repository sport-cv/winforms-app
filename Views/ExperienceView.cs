using SportCv.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Views
{
    public partial class ExperienceView : Form
    {
        private const int START_SEASON = 1950;

        private IExperience _currentExperience;

        public Action OnExperienceUpdated;
        public ExperienceView()
        {
            InitializeComponent();
            SeasonCombobox.Items.AddRange(LoadSeasons(START_SEASON));
            SeasonCombobox.DisplayMember = "Text";
        }

        public void Refresh(IExperience experience)
        {
            _currentExperience = experience;
            SeasonCombobox.SelectedIndex = experience.Season.StartYear < START_SEASON ? -1 : SeasonCombobox.FindString(_currentExperience.Season.StartYear.ToString());
            ClubTextbox.Text = _currentExperience.Club;
            RoleTextbox.Text = _currentExperience.Role;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                ExitButton_Click(this, EventArgs.Empty);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _currentExperience = null;
            Hide();
        }

        private object[] LoadSeasons(int startYear)
        {
            var seasons = new List<object>();

            for (int i = startYear; i <= DateTime.Now.Year; i++)
            {
                seasons.Add(new { Value = i,  Text = $"{i}/{(i + 1).ToString().Substring(2, 2)}" });
            }

            return seasons.ToArray();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int startYear = ((dynamic)SeasonCombobox.SelectedItem).Value;

            _currentExperience.Season = new Season { StartYear = startYear, EndYear = startYear + 1 };
            _currentExperience.Club = ClubTextbox.Text;
            _currentExperience.Role = RoleTextbox.Text;

            OnExperienceUpdated();
        }
    }
}
