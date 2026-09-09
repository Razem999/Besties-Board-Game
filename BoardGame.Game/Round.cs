using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Game
{
    internal class Round
    {
        public int roundNumber { get; set; }
        public Card cardsInPlay { get; set; }
        public List<PlayerRoundScore> playerRoundScores { get; set; } = new List<PlayerRoundScore>();

        public Round(int roundNumber, Card cardsInPlay)
        {
            this.roundNumber = roundNumber;
            this.cardsInPlay = cardsInPlay;
        }

        public void StartRound()
        {
            // Logic to start the round
        }

        public void EndRound()
        {
            // Logic to end the round
        }

        public void DrawCards()
        {
            // Logic to draw cards for the round
        }

        public void SwapCard()
        {
            // Logic to swap a card in the round
        }

        public void SwapAll()
        {
            // Logic to swap all cards in the round
        }
    }
}
