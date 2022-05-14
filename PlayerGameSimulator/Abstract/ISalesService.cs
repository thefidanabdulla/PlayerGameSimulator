using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Abstract
{
    public interface ISalesService
    {
        void Buy(Player player, Game game);
        void BuyWithCampaign(Player player, Game game , Campaign campaign);
    }
}
