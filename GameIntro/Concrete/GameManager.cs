using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName+ " "+ " added to library");
        }

       
    }
}
