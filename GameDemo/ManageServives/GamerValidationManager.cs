using GameDemo.Entities;
using GameDemo.Interfaces;
using MernisValidationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.ManageServives
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool CheckValidation(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.GamerNationalId, gamer.GamerFirstName, gamer.GamerLastName, gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }


    }

}
