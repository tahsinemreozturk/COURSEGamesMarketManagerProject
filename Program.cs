using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSEGamesMarketManagerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirtYear = 2002,
                FırstName = "Emre",
                LastName = "Ozturk",
                IdentityNumber = 12345
            });
            Console.ReadLine();

        }
    }
}
