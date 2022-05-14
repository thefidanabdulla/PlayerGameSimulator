using PlayerGameSimulator.Concrete;
using PlayerGameSimulator.Entities;
using System;

namespace PlayerGameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player(Id: 1, FirstName: "Fidan", Lastname: "Abdulla", YearOfBirth: 2004);
            CheckPlayerInfoManager checkPlayerInfoManager = new CheckPlayerInfoManager();
            checkPlayerInfoManager.CheckPlayerInfo(newPlayer);

            Console.WriteLine("*********************");

            Game newGame = new Game(GameId: 1, Name: "CallOfDuty", Price: 20);
            GameCheckManager gameCheckManager = new GameCheckManager();
            gameCheckManager.Save(newGame);

            Console.WriteLine("*********************");

            Campaign newCampaign = new Campaign(CampaignId: 1, Name: "BlackFriday", Content: "20% off special for Black Friday.");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(newCampaign);

            Console.WriteLine("*********************");

            SaleGameManager saleGameManager = new SaleGameManager();
            saleGameManager.Buy(newPlayer, newGame);

            Console.WriteLine("*********************");

            saleGameManager.BuyWithCampaign(newPlayer, newGame, newCampaign);
        }
    }
}
