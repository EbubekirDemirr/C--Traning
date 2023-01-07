using System;
using GameIntro.MernisServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIntro.Abstract;

namespace GameIntro.Adapters
{
    public class MernisServiceAdapters:IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.NationaltyId), player.FirstName.ToUpper(), player.LastName.ToUpper(),
                player.DateofBirth.Year);
        }
    }
}
