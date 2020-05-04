using Models.PlanetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPlanetService
    {
        void CreatePlanet(PlanetCreateModel planetToCreate);
        IEnumerable<PlanetListItem> GetPlanets();
        PlanetDetailModel GetPlanetDetailById();
        void UpdatePlanet(PlanetUpdateModel planetToUpdate);
        void DeletePlanet(PlanetDeleteModel planetToDelete);
    }
}
