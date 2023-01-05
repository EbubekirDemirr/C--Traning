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
        void NewCampaigning(Campaigning campaigning);
        void UpdateCampaigning(Campaigning campaigning);
        void DeleteCampaigning(Campaigning campaigning);

    }
}
