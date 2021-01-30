using GameDemo.Campaign;
using GameDemo.Entities;
using GameDemo.Interfaces;
using GameDemo.ManageServives;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------Sisteme oyuncu ekleme/Kimlik doğrulaması---------->");

            Gamer gamer1 = new Gamer() {GamerId=101, GamerFirstName = "Engin", GamerLastName = "Demiroğ", GamerNationalId = 28861499108, DateOfBirth = new DateTime(1985, 1, 6) };
            GamerManagerServices gamerManagerServices = new GamerManagerServices(new GamerValidationManager());
            gamerManagerServices.Add(gamer1);

            Gamer gamer2 = new Gamer() { GamerId = 102, GamerFirstName = "Nur", GamerLastName = "Yavuz", GamerNationalId = 12345678901, DateOfBirth = new DateTime(1997, 9, 3) };
            gamerManagerServices.Add(gamer2);

            Gamer gamer3 = new Gamer() { GamerId = 103, GamerFirstName = "Emine", GamerLastName = "Kabasakal", GamerNationalId = 53971267774, DateOfBirth = new DateTime(1980, 8, 1) };
            gamerManagerServices.Add(gamer3);

            Gamer gamer4 = new Gamer() { GamerId = 104, GamerFirstName = "Metin", GamerLastName = "Er", GamerNationalId = 24567413204, DateOfBirth = new DateTime(2020, 6, 7) };
            gamerManagerServices.Add(gamer4);

            List<Gamer> gamers = new List<Gamer> { gamer1, gamer2, gamer3, gamer4 };

            Console.WriteLine("<----------Oyuncunun Sistemden Silinmesi---------->");
            gamerManagerServices.Delete(gamer2);
            gamerManagerServices.Delete(gamer4);

            Console.WriteLine("<----------Oyuncu Bilgilerinin Güncellenmesi---------->");
            gamerManagerServices.Update(gamer2);
            gamerManagerServices.Update(gamer4);

            //Kampanya objesi oluşturma
            Campaigns campaigns1 = new Campaigns(); 
            Campaigns campaigns2 = new Campaigns();
            Campaigns campaigns3 = new Campaigns();

            NewYearCampaign newYearCampaign = new NewYearCampaign(campaigns1);
            ValentinesDayCampaign valentinesDayCampaign = new ValentinesDayCampaign(campaigns2);
            BlackFridayCampaign blackFridayCampaign = new BlackFridayCampaign(campaigns3);
            
            Console.WriteLine("<----------Sevgililer Günü Kampanyası Satış Özeti---------->");
            Sales sales1 = new Sales() { SalesRate = "%70" };
            SalesManagerService salesManagerService1 = new SalesManagerService(new GamerValidationManager());
            salesManagerService1.CampaignSale(gamers, valentinesDayCampaign, campaigns2);
            salesManagerService1.SalesSummary(campaigns2, sales1);

            Console.WriteLine("<----------Yeni Yıl Kampanyası Satış Özeti---------->");

            Sales sales2 = new Sales() { SalesRate = "%55" };
            SalesManagerService salesManagerService2 = new SalesManagerService(new GamerValidationManager());
            salesManagerService2.CampaignSale(gamers, newYearCampaign, campaigns1);
            salesManagerService2.SalesSummary(campaigns1, sales2);

            Console.WriteLine("<----------Kara Cuma Kampanyası Satış Özeti---------->");

            Sales sales3 = new Sales() { SalesRate = "%85" };
            SalesManagerService salesManagerService3 = new SalesManagerService(new GamerValidationManager());
            salesManagerService3.CampaignSale(gamers, blackFridayCampaign, campaigns3);
            salesManagerService3.SalesSummary(campaigns3, sales3);

            Console.WriteLine("<----------Kampanyaların Güncellenmesi---------->");
       
            newYearCampaign.Update();
            valentinesDayCampaign.Update();
            blackFridayCampaign.Update();

            Console.WriteLine("<----------Kampanyaların Sona Ermesi---------->");

            newYearCampaign.Delete();
            valentinesDayCampaign.Delete();
            blackFridayCampaign.Delete();
        }
    }
}