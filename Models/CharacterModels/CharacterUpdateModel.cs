using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
    class CharacterUpdateModel
    {
        public int CharacterId { get; set; }
        public string UpdatedFirstName { get; set; }
        public string UpdatedLastName { get; set; }
        public string UpdatedAffiliation { get; set; }
        public string UpdatedWeaponOfChoice { get; set; }
        public int UpdatedPlanetId { get; set; }
        public int UpdatedShipId { get; set; }
    }
}
