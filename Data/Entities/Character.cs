using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Race { get; set; }
        public string Affiliation { get; set; }
        public string WeaponOfChoice { get; set; }
        [ForeignKey ("Planet")]
        public int PlanetId { get; set; }
        [ForeignKey ("Ship")]
        public int ShipId { get; set; }
    }
}
