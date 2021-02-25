using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
  public  class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
