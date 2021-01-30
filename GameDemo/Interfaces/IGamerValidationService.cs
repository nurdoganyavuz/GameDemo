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


//public bool CheckValidation(Gamer gamer)
//{
//    KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

//    return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.GamerId, gamer.GamerFirstName, gamer.GamerLastName, gamer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;

//}