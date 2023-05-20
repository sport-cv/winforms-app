using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Entities
{
    public class CoachExperience : Experience
    {
        public CoachExperience() : base(new Season(), string.Empty, "Treinador")
        {
        }
        public CoachExperience(Season season, string club, int victories, int gamesPlayed) : base(season, club, "Treinador")
        {
            GamesPlayed = gamesPlayed;
            Victories = victories;
        }

        public int Victories { get; set; }
        public int GamesPlayed { get; set; }

        public override string FullDescription()
        {
            return $"Como {Role} na época {ShortSeasonDisplay()} no clube {Club} venceu {Victories / GamesPlayed * 100}% jogos.";
        }
    }
}
