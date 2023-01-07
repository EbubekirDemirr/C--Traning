using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface ISaleManager
    {
        void Sale(Campaigning campaigning, Player player, Game game);
    }
}
