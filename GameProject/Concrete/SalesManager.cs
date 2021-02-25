using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - (game.GamePrice * campaign.Discount/100);
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+game.GameName+" nunu"+campaign.CampaignName+" kampanyası ile %"+campaign.Discount+" indimle "+campaignPrice+" TL'ye satın aldı");
        }

        public void Sales(Gamer gamer,Game game)
        {
            
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+game.GameName+" nunu"+game.GamePrice+"TL'ye Satın Aldı.");
        }
    }
}
