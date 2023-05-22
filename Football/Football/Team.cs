using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        private Coach coach;
        private List<FootballPlayer> players;

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            if (players.Count < 11 || players.Count > 22)
                throw new ArgumentException("Player count in the team should be between 11 and 22");
            else
                this.players = players;
        }

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public List<FootballPlayer> Players
        {
            get { return players; }
        }

        public int AverageAgeOfPlayers
        {
            get
            {
                int totalAge = 0;
                foreach (FootballPlayer player in players)
                {
                    totalAge += player.Age;
                }

                if (players.Count > 0)
                {
                    return totalAge / players.Count;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
