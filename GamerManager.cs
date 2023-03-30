using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSEGamesMarketManagerProject
{
    //MicroService(Baska servislerin kullanilmasi).
    internal class GamerManager : IGamerService
    {
        UserVerificationService userVerificationService;

        public GamerManager(UserVerificationService userVerificationService)
        {
            this.userVerificationService = userVerificationService;
        }

        public void Add(Gamer gamer)
        {
            if (userVerificationService.Validate(gamer)== true)
            {
                Console.WriteLine("Kayit oldu");

            }
            else
            {
                Console.WriteLine("Kayit Basarisiz");
            }
            Console.WriteLine("Kayit Oldu");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi");
        }
    }
}
