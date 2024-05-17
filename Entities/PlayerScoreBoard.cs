using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyQuestionsClient.Entities
{
    internal class PlayerScoreBoard
    {
        public Player _Player { get; set; }

        public int _Score { get; set; }

        public PlayerScoreBoard(Player p) 
        {
            _Player = p;
            _Score = 0;
        }

        public void CorrectAnswer()
        {
            _Score += 5;
        }

        public void OtherWrongAnswer()
        {
            _Score += 1;
        }
    }
}
