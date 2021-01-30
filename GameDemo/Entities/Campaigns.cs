using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Campaigns : IEntity
    {
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
    }
}
