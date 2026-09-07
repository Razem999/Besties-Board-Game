using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Game
{
    internal class ScoreBoard
    {
        private readonly Dictionary<string, int> _scores = new();
        public IReadOnlyDictionary<string, int> Scores => _scores;

        public void InitializePlayerScores(List<Player> players)
        {
            foreach (var player in players)
            {
                _scores[player.playerId] = 0;
            }
        }

        public void AddRoundScores(Round round)
        {
            foreach (var playerScore in round.playerRoundScores)
            {
                if (_scores.ContainsKey(playerScore.playerId))
                {
                    _scores[playerScore.playerId] += playerScore.roundScore;

                }
                else
                {
                    _scores[playerScore.playerId] = playerScore.roundScore;
                }
            }
        }
    }
}
