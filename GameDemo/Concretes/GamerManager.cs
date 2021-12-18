using GameDemo.Abstracts;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concretes
{
    class GamerManager : IGamerService

    {
        IGamerCheckService _gamercheckservice;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamercheckservice = gamerCheckService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_gamercheckservice.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer " + gamer.FirstName + " Added");
            }
            
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " Removed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " Updated ");
        }
    }
}
