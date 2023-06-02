using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Entities
{
    public abstract class Experience : IExperience
    {
        public Experience(Season season, string club, string role)
        {
            Season = season;
            Club = club;
            Role = role;
        }

        public Season Season { get; set; }
        public string Club { get; set; }
        public string Role { get; set; }

        public abstract string FullDescription();
        public string ShortDescription()
        {
            return $"{ShortSeasonDisplay()} | {Club} | {Role}";
        }

        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { ShortSeasonDisplay(), Club, Role });
        }

        internal string ShortSeasonDisplay()
        {
            string decade = Season.EndYear.ToString().Substring(2,2);
            return $"{Season.StartYear}/{decade}";
        }
    }

    public struct Season
    {
        public int StartYear;
        public int EndYear;
    }
}
