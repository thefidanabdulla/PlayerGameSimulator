using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Entities
{
    public class Game
    {
        public Game(int GameId, string Name, int Price )
        {
            this.GameId = GameId;
            this.Name = Name;
            this.Price = Price;
        }
        public int GameId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
