using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface ICampaigningService
    {
        void AddCampaigning(Campaigning campaigning);
        void DeletedCampaigning (Campaigning campaigning);
        void UpdateCampaigning (Campaigning campaigning);
    }
}
