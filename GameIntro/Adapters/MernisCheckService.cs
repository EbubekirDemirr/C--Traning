using GameIntro.Abstract;
using System;
using GameIntro.MernisServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Adapters
{
    public class MernisCheckService: IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.NationaltyId), player.FirstName.ToUpper(), player.LastName.ToUpper(),
                player.DateofBirth.Year);
        }
    }
}
