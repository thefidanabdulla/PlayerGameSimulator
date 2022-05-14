using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Abstract
{
    public interface IGameService
    {
        void Save(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
