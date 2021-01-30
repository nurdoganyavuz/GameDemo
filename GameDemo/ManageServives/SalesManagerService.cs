using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.ManageServives
{
    class SalesManagerService
    {
        IGamerValidationService _gamerValidationService;

        public SalesManagerService(IGamerValidationService gamerValidationService) //constrcutor -->satış yapılacagında kullanıcı doğrulaması yapılsın istiyorum. *Her satış için* bunun olmasını istenildiğinden ctor kullanıldı.
        {                                                                          //bu yüzden salesmanager **newlendiği zaman** parametre olarak bir doğrulama servisi ister.
            this._gamerValidationService = gamerValidationService;                //şu anda sadece Mernis ile doğrulama yapıyor ama ilerde DatabaseValidationManager diye baska bir doğrulama sınıfı olusturulursa
        }                                                                         //ve bu servise IGamerValidation implement edilirse, salesmanager newlendiğinde mernisi kullanabildiği gibi database doğrulamasını da kullanabilir. Bu yüzden ctor olusturulmalıdır.
        public void CampaignSale(List<Gamer> gamers, ICampaignService campaignService, Campaigns campaigns)
        {
            
            campaignService.Add();
            foreach (var gamer in gamers)
            {
                if (_gamerValidationService.CheckValidation(gamer) == true)
                {
                    Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName.ToUpper() + " isimli kullanıcı " + campaigns.CampaignName + "ndan yararlanarak üyelik satın aldı.");
                }
                else
                {
                    Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName.ToUpper() + " isimli kullanıcın kimlik doğrulaması başarısız olduğu için üye işlemleri yapılamaz!");
                }
                
            }
        }
        public void SalesSummary(Campaigns campaigns, Sales sales)
        {
            Console.WriteLine(campaigns.CampaignName + " ile birlikte " + sales.SalesRate + " oranında satış yapıldı.");
             
        }
    }
}