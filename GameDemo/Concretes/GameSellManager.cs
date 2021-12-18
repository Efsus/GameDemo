using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstracts;
using GameDemo.Concretes;
using GameDemo.Entities;

namespace GameDemo.Concretes
{
    class GameSellManager : IGameSellService
    {
        public void SellWithCampaign(Gamer gamer , Campaign campaign , Game game)
        {
            double NewPrice = game.Price - (game.Price * campaign.CampaignRatio);
            Console.WriteLine(game.GameName+ " has been sold for " + NewPrice + " to " + gamer.FirstName + " using the " + campaign.CampaignName);
        }
     
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " has been sold for " + game.Price + " to " + gamer.FirstName);
        }

       
       
    }
}
