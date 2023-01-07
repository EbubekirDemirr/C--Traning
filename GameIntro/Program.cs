using GameIntro.Abstract;
using GameIntro.Adapters;
using GameIntro.Concrete;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PlayerManager playerManager = new PlayerManager(new MernisServiceAdapters());
            //playerManager.Add(


            Player player = new Player
            {
                DateofBirth = new DateTime(1998, 1, 25),
                FirstName = "Ebubekir",
                LastName = "Demir",
                NationaltyId = "19456193334"
            };

            Game game = new Game
            {
                Id = 1,
                GameName = "Sultanlar Sofrası",
                GamePrice = 20,
            };

            Campaigning campaigning = new Campaigning
            {
                CampaigningName = "Summer Sale",
                DiscountRate = "%25"
            };



            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapters());
            playerManager.Add(player);

            GameManager gameManager = new GameManager();
            gameManager.AddGame(game);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(campaigning, player, game);

            
            




            Console.ReadLine();

        }
    }
}
