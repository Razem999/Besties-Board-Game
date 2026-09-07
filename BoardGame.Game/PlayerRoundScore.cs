using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Game
{
    internal class PlayerRoundScore
    {
        public string playerId { get; set; }
        public string playerName { get; set; }
        public int roundScore { get; set; } = 0;
    }
}
