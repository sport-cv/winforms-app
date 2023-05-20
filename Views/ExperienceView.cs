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

            SpecificFlowLayout.Controls.Clear();

            if (_currentExperience is PlayerExperience playerExperience)
            {
                LoadPlayerSpecificControls(playerExperience);
            }
            else if (_currentExperience is CoachExperience coachExperience)
            {
                LoadCoachSpecificControls(coachExperience);
            }
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

            for (int i = DateTime.Now.Year; i > startYear ; i--)
            {
                seasons.Add(new { Value = i, Text = $"{i}/{(i + 1).ToString().Substring(2, 2)}" });
            }

            return seasons.ToArray();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int startYear = ((dynamic)SeasonCombobox.SelectedItem).Value;

            _currentExperience.Season = new Season { StartYear = startYear, EndYear = startYear + 1 };
            _currentExperience.Club = ClubTextbox.Text;
            _currentExperience.Role = RoleTextbox.Text;

            if(_currentExperience is PlayerExperience playerExperience)
            {
                SavePlayerSpecificData(playerExperience);
            }
            else if (_currentExperience is CoachExperience coachExperience)
            {
                SaveCoachSpecificData(coachExperience);
            }

            OnExperienceUpdated();
        }

        public void LoadPlayerSpecificControls(PlayerExperience playerExperience)
        {
            var positionLabel = new Label { Name = "PositionLabel", Text = "Posição", AutoSize = true };
            var positionTextbox = new TextBox { Name = "PositionTextbox", Text = playerExperience.Position };
            SpecificFlowLayout.Controls.Add(positionLabel);
            SpecificFlowLayout.Controls.Add(positionTextbox);

            var gamesLabel = new Label { Name = "GamesLabel", Text = "Nr. Jogos", AutoSize = true };
            var gamesNumeric = new NumericUpDown() { Name = "GamesNumeric", Value = playerExperience.GamesPlayed };
            SpecificFlowLayout.Controls.Add(gamesLabel);
            SpecificFlowLayout.Controls.Add(gamesNumeric);

            var goalsLabel = new Label { Name = "GoalsLabel", Text = "Golos Marcados", AutoSize = true };
            var goalsNumeric = new NumericUpDown() { Name = "GoalsNumeric", Value = playerExperience.Goals };
            SpecificFlowLayout.Controls.Add(goalsLabel);
            SpecificFlowLayout.Controls.Add(goalsNumeric);
        }

        private void SavePlayerSpecificData(PlayerExperience playerExperience)
        {
            foreach (Control control in SpecificFlowLayout.Controls)
            {
                if (control is TextBox textbox)
                {
                    playerExperience.Position = textbox.Text;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    switch (numericUpDown.Name)
                    {
                        case "GoalsNumeric":
                            playerExperience.Goals = (int)numericUpDown.Value;
                            break;
                        case "GamesNumeric":
                            playerExperience.GamesPlayed = (int)numericUpDown.Value;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void LoadCoachSpecificControls(CoachExperience coachExperience)
        {
            var gamesLabel = new Label { Name = "GamesLabel", Text = "Nr. Jogos", AutoSize = true };
            var gamesNumeric = new NumericUpDown() { Name = "GamesNumeric", Value = coachExperience.GamesPlayed };
            SpecificFlowLayout.Controls.Add(gamesLabel);
            SpecificFlowLayout.Controls.Add(gamesNumeric);

            var victoriesLabel = new Label { Name = "VictoriesLabel", Text = "Nr. Vitórias", AutoSize = true };
            var victoriesNumeric = new NumericUpDown() { Name = "VictoriesNumeric", Value = coachExperience.Victories };
            SpecificFlowLayout.Controls.Add(victoriesLabel);
            SpecificFlowLayout.Controls.Add(victoriesNumeric);
        }

        private void SaveCoachSpecificData(CoachExperience coachExperience)
        {
            foreach (Control control in SpecificFlowLayout.Controls)
            {
                switch (control.Name)
                {
                    case "VictoriesNumeric":
                        coachExperience.Victories = int.Parse(control.Text);
                        break;
                    case "GamesNumeric":
                        coachExperience.GamesPlayed = int.Parse(control.Text);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
