using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PlanetModels
{
    public class PlanetUpdateModel
    {
        public int PlanetId { get; set; }
        public string UpdatedPlanetName { get; set; }
        public string UpdatedPlanetDescription { get; set; }
        public string UpdatedPlanetClimate { get; set; }
        public string UpdatedHoursPerDay { get; set; }
        public string UpdatedDaysPerYear { get; set; }
        public string UpdatedNumberOfSuns { get; set; }
        public string UpdatedNumberOfMoons { get; set; }
    }
}
