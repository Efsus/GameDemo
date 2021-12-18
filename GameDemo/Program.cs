using GameDemo.Entities;
using GameDemo.Abstracts;
using GameDemo.Concretes;
using System;



namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer Yusuf = new Gamer()
            {
                DateOfBirth = new DateTime(2006, 07, 27), FirstName = "Yusuf", LastName = "Gökdoğan",IdentityNo = 11100027                                           
            };

            Gamer Yigit = new Gamer()
            {
                DateOfBirth = new DateTime(2008 , 02 ,15), FirstName = "Yiğit" , LastName = "Erdoğan" , IdentityNo = 11100028
            };

            Campaign campaign1 = new Campaign() 
            { 
                CampaignName = "Summer Discount" , CampaignRatio = 0.50f , Id = 91011
            };

            Game game1 = new Game()
            {
                GameName = "The Witcher 3" , Price = 30
            };



            IGamerService gamerService = new GamerManager(new GamerCheckService());
            gamerService.Add(Yusuf);

            ICampaignService campaign = new CampaignManager();
            campaign.AddCampaign(campaign1);

            IGameSellService gamesell = new GameSellManager();
            gamesell.SellWithCampaign(Yusuf, campaign1, game1);

            IGameSellService gamesell2 = new GameSellManager();
            gamesell2.Sell(game1, Yigit);



            Console.ReadLine();

        }
    }
}
