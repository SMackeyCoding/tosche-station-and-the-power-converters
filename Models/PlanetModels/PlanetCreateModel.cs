﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PlanetModels
{
    public class PlanetCreateModel
    {
        [Required]
        public string PlanetName { get; set; }
        public string PlanetDescription { get; set; }
        public string PlanetClimate { get; set; }
        public int HoursPerDay { get; set; }
        public int DaysPerYear { get; set; }
        public int NumberOfSuns { get; set; }
        public int NumberOfMoons { get; set; }
    }
}
