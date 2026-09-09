using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Game
{
    internal class GameState
    {
        public string gameId { get; set; }
        public GameStatus status = GameStatus.INLOBBY;
        public List<Player> playerList { get; set; } = new();
        public Player currentStar { get; set; }
        public int totalRounds = 0;
        public List<Round> rounds { get; set; } = new();
        public Round currentRound { get; set; }
        public Deck gameDeck { get; set; }
        public ScoreBoard scoreBoard { get; set; }

        public GameState(string gameId, int totalRounds)
        {
            this.gameId = gameId;
            this.status = GameStatus.INLOBBY;
            this.totalRounds = totalRounds;
        }

        public void AddPlayer(Player player)
        {
            this.playerList.Add(player);
        }

        public void RemovePlayer(string playerId)
        {
            int removedCount = playerList.RemoveAll(player => player.playerId == playerId);

            if (removedCount > 0)
            {
                // Clean up network connections
                // Broadcast to other players
                Console.WriteLine("Successfully removed player");
            } 
            else
            {
                Console.WriteLine("Failed to remove player");
            }
        }
    }
}
