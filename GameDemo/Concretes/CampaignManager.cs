using GameDemo.Entities;
using GameDemo.Concretes;
using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concretes
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("The " + campaign.CampaignName + " is added.");
        }

        public void RemoveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is deleted.");
        }
        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is updated.");
        }
    }
}
