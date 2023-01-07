using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class SalesManager : ISaleManager
    {
        public void Sale( Campaigning campaigning, Player player, Game game)
        {
            Console.WriteLine(game.GameName+ " oyunu "+ campaigning.CampaigningName + " kampanyasıyla "
                + campaigning.DiscountRate+ " indirim oranıyla "+ player.FirstName + " oyuncusuna satılmıştır.");
        }
    }
}
