using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class CampaigningManager : ICampaigningService
    {
        public void AddCampaigning(Campaigning campaigning)
        {
            Console.WriteLine(campaigning.CampaigningName + "added campaigning");
        }

        public void DeletedCampaigning(Campaigning campaigning)
        {
            Console.WriteLine(campaigning.CampaigningName + "Deleted campaigning");
        }

        public void UpdateCampaigning(Campaigning campaigning)
        {
            Console.WriteLine(campaigning.CampaigningName + "Updated campaigning");
        }
    }
}
