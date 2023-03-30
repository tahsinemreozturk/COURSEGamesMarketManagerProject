using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSEGamesMarketManagerProject
{
    internal interface UserVerificationService
    {
        bool Validate(Gamer gamer);
    }
}
