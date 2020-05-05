using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    class Ship
    {
        [Key]
        public int ShipId { get; set; }
        [Required]
        public string ShipName { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Length { get; set; }
        public int MaxSpeed { get; set; }
    }
}
