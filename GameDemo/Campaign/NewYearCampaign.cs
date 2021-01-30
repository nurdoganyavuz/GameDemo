using GameDemo.Entities;
using GameDemo.Interfaces;
using GameDemo.ManageServives;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Campaign
{
    class NewYearCampaign : ICampaignService
    {
        Campaigns _campaigns;

        public NewYearCampaign(Campaigns campaigns) //constrcutor
        {
            this._campaigns = campaigns;
            _campaigns.DiscountRate = 60;
            _campaigns.CampaignName = "Yeni Yıl Kampanyası";

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