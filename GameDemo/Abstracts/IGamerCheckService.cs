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
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
