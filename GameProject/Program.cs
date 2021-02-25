using System;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;


namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager=new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(new Gamer() { DateOfBirth = new DateTime(1984, 1, 7), FirstName = "Serpil", LastName = "Azman", IdentityNumber = 12345367876 });


            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Serpil";
            gamer1.LastName = "AZMAN";
            gamer1.DateOfBirth = new DateTime(1984, 8, 30);
            gamer1.IdentityNumber = 12345678909;
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Delete(gamer1);
            gamerManager1.Update(gamer1);
            

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "LordOfTheGame";
            game1.GamePrice = 325;

            GameManager gameManager = new GameManager();
            gameManager.Save(new Game() { Id = 1, GameName = "Game1" });
            gameManager.Delete(new Game() { Id = 1, GameName = "Game1" });
            gameManager.Update(new Game() { Id = 1, GameName = "Game1" });

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Kampanya Cuma";
            campaign1.Discount = 25;


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(new Campaign() { Id=1,CampaignName="Kampanya1",Discount=10,ExpiryDate=new DateTime(2021,3,31)});


            SalesManager salesManager = new SalesManager();
            salesManager.CampaignSales(game1,gamer1,campaign1);
            salesManager.Sales(gamer1,game1);
            Console.ReadLine();
        }
    }
}
