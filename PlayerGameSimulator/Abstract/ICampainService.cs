using PlayerGameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Abstract
{
    public interface ICampainService
    {
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);        
    }
}
