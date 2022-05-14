using PlayerGameSimulator.Abstract;
using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Concrete
{
    public class GameCheckManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " game deleted.");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.Name + " game added succesfully :)");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " game updated.");
        }
    }
}
