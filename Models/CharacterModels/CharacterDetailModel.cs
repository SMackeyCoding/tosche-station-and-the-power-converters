﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
    public class CharacterDetailModel
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Race { get; set; }
        public string Affiliation { get; set; }
        public string WeaponOfChoice { get; set; }
        public int PlanetId { get; set; }
        public int ShipId { get; set; }
    }
}
