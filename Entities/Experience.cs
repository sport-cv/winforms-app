using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal String ShortSeasonDisplay()
        {
            int decade = Season.EndYear > 1999 ? Season.EndYear - 2000 : Season.EndYear - 1900;
            return $"{Season.StartYear}/{decade}";
        }
    }

    public struct Season
    {
        public int StartYear;
        public int EndYear;
    }
}
