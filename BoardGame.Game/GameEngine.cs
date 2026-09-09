using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Game
{
    enum GameStatus
    {
        INPROGRESS,
        COMPLETE,
        INLOBBY
    }
    internal class GameEngine
    {
        public GameState StartGame(GameState state)
        {
            return state;
        }

        public GameState EndGame(GameState state)
        {
            return state;
        }

        public GameState NextTurn(GameState state)
        {
            return state;
        }

        public GameState EndTurn(GameState state)
        {
            return state;
        }

        public GameState NextRound(GameState state)
        {
            return state;
        }
    }
}
