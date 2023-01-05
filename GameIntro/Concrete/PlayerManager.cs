using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class PlayerManager:IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName+ " " + player.LastName+ " added!");
        }

        public void Remove(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " removed!");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName+ " " +player.LastName+ " updated!");
        }
    }
}
