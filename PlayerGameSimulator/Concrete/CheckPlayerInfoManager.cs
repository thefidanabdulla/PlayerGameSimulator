using PlayerGameSimulator.Abstract;
using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Concrete
{
    class CheckPlayerInfoManager : IPlayerInfoCheckService
    {
        public void CheckPlayerInfo(Player player)
        {
            Console.WriteLine("New Player " + player.FirstName +" added succesfully");
        }
    }
}
