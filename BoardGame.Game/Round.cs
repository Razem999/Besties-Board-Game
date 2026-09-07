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

        public void startRound()
        {
            // Logic to start the round
        }

        public void endRound()
        {
            // Logic to end the round
        }

        public void drawCards()
        {
            // Logic to draw cards for the round
        }

        public void swapCard()
        {
            // Logic to swap a card in the round
        }

        public void swapAll()
        {
            // Logic to swap all cards in the round
        }
    }
}
