using GameDemo.Entities;
using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Campaign
{
    class BlackFridayCampaign : ICampaignService
    {
        Campaigns _campaigns;

        public BlackFridayCampaign(Campaigns campaigns) //constructor
        {
            this._campaigns = campaigns;
            _campaigns.DiscountRate = 65;
            _campaigns.CampaignName = "Kara Cuma Kampanyası";

        }
        public void Add()
        {
            Console.WriteLine(_campaigns.CampaignName + " aktifleştirildi.");
        }

        public void Delete()
        {
            Console.WriteLine(_campaigns.CampaignName + " sona erdi.");
        }

        public void Update()
        {
            Console.WriteLine(_campaigns.CampaignName + " indirim oranları güncellendi. V.I.P. üyeliklerde %" + _campaigns.DiscountRate + " indirim fırsatı!");
        }
    }
}