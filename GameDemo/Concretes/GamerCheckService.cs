using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstracts;
using GameDemo.Entities;
using GameDemo.Concretes;

namespace GameDemo.Concretes
{
    class GamerCheckService : IGamerCheckService
    {
        bool IGamerCheckService.CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName == "Yusuf" && gamer.LastName == "Gökdoğan" && gamer.DateOfBirth.Year == 2006 && gamer.IdentityNo == 11100027)
            {
                return true;
            }
            else
            {
                throw new Exception("Not a valid user");
            }
        }
    }
}
