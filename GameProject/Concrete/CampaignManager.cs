using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        
        public void Save(Campaign campaign)
        {
            Console.WriteLine("Saved to DB:"+campaign.CampaignName+" Expiry Date:"+campaign.ExpiryDate);
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

    }
}
