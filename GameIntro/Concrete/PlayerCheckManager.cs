﻿using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class PlayerCheckManager:IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player  player)
        {
            return true;
        }
    }
}
