using GameDemo.Entities;
using MernisValidationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interfaces
{
    interface IGamerValidationService
    {
        bool CheckValidation(Gamer gamer);

        
    }
}