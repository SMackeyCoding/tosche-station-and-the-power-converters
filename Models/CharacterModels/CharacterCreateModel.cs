using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
    public class CharacterCreateModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Race { get; set; }
        public string Affiliation { get; set; }
        public string WeaponOfChoice { get; set; }
        public int PlanetId { get; set; }
        public int ShipId { get; set; }
    }
}
