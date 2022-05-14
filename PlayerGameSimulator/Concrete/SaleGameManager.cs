using PlayerGameSimulator.Abstract;
using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Concrete
{
    class SaleGameManager : ISalesService
    {
        public void Buy(Player player, Game game)
        {
            Console.WriteLine("Player " + player.FirstName + " buy the " + game.Name + " game, congratulations :)" ) ;
        }

        public void BuyWithCampaign(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("Player " + player.FirstName + " buy the " + game.Name + " game, with " + campaign.Name +" campaign, congratulations :)");
        }
    }
}
