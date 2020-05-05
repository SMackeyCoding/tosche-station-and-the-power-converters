﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ShipModels
{
    public class ShipCreateModels
    {
        [Required]
        public int ShipID { get; set; }
        public string ShipName { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Length { get; set; }
        public int MaxSpeed { get; set; }
    }
}

