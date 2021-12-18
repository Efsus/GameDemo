using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstracts;
using GameDemo.Concretes;
using GameDemo.Entities;

namespace GameDemo.Abstracts
{
    interface ICampaignService
    {
        public void AddCampaign(Campaign campaign);
        public void RemoveCampaign(Campaign campaign);
        public void UpdateCampaign(Campaign campaign);
    }
}
