﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface ICampaignService
    {
        void Save(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
