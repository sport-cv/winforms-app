using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Entities
{
    public class PlayerExperience : Experience
    {
        public PlayerExperience(Season season, string club, int goals, int gamesPlayed) : base(season, club, "Jogador")
        {
            Goals = goals;
            GamesPlayed = gamesPlayed;
        }

        public String Position { get; set; }
        public int Goals { get; set; }
        public int GamesPlayed { get; set; }

        public override string FullDescription()
        {
            return $"Como {Role} na época {ShortSeasonDisplay()} no clube {Club} onde marcou {Goals} golos em {GamesPlayed} jogos.";   
        }
    }
}
