using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    public class PlayerManager : Base
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " " + "Player Added");
            }
            else
            {
                Console.WriteLine(player.FirstName + " " + "Player not a real Person");
            }
        }
       




    }
}
