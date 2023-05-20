using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Entities
{
    public class StaffExperience : Experience
    {
        public StaffExperience() : base(new Season(), string.Empty, "Diretor")
        {
        }

        public StaffExperience(Season season, string club) : base(season, club, "Diretor")
        {
        }

        public override string FullDescription()
        {
            return $"Colaborou como {Role} na época {ShortSeasonDisplay()} no clube {Club}.";
        }
    }
}
