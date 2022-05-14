using PlayerGameSimulator.Abstract;
using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Concrete
{
    class CampaignManager : ICampainService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign deleted.");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign added succesfully.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign updated.");
        }
    }
}
