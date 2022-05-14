using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Abstract
{
    public interface IPlayerInfoCheckService
    {
        void CheckPlayerInfo(Player player);
    }
}
