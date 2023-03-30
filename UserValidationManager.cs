using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSEGamesMarketManagerProject
{
    internal class UserValidationManager : UserVerificationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 2002 && gamer.FırstName == "Emre" && gamer.LastName == "Ozturk" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
