using GameDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Gamer : IEntity
    {
        public int GamerId { get; set; }

        public long GamerNationalId { get; set; }

        public string GamerFirstName { get; set; }

        public string GamerLastName { get; set; }

        public DateTime DateOfBirth{ get; set; }
    }
}
