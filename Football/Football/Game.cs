using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private List<Referee> assistantReferees;
        private Dictionary<int, FootballPlayer> goals;
        private int team1Goals, team2Goals;

        public Game()
        {
            team1Goals = 0;
            team2Goals = 0;
            assistantReferees = new List<Referee>();
            goals = new Dictionary<int, FootballPlayer>();
        }

        public Team Team1
        {
            get { return team1; }
            set {
                if (value.Players.Count != 11)
                    throw new ArgumentException("In a game player count in the team should be 11 only");
                else
                    team1 = value; 
            }
        }

        public Team Team2
        {
            get { return team2; }
            set
            {
                if (value.Players.Count != 11)
                    throw new ArgumentException("In a game player count in the team should be 11 only");
                else
                    team2 = value;
            }
        }

        public Referee Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        public List<Referee> AssistantReferees
        {
            get { return assistantReferees; }
        }

        public Dictionary<int, FootballPlayer> Goals
        {
            get { return goals; }
        }

        public string GameResult
        {
            get
            {
                foreach (var goal in goals)
                {
                    if(Team1.Players.Contains(goal.Value))
                        team1Goals++;
                    else if(Team2.Players.Contains(goal.Value))
                        team2Goals++;
                }
                return $"{team1Goals} : {team2Goals}";
            }
        }

        public string Winner
        {
            get
            {
                if (team1Goals == team2Goals)
                    return "Draw";
                else if (team1Goals > team2Goals)
                    return "Team 1";
                else
                    return "Team 2";
            }
        }
    }
}
