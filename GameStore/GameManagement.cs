using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GameManagement
    {
        public List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
        }
        
        public void Update(Game game)
        {
            games[games.IndexOf(game)] = game;
        }

        public List<Game> Games
        {
            get { return games; }
        }
    }
}
