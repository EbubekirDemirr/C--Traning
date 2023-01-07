using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public abstract class Base : IPlayerService
    {
        public virtual void Add(Player player)
        {
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + "Player Deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + "Player Updated");
        }
    }
}
