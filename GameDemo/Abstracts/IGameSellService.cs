using GameDemo.Entities;
using GameDemo.Abstracts;
using GameDemo.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstracts
{
    interface IGameSellService
    {
        public void SellWithCampaign(Gamer gamer, Campaign campaign, Game game);
        public void Sell(Game game, Gamer gamer);
    }
}
