using Contracts;
using Models.PlanetModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PlanetController : ApiController
    {
        private PlanetService CreatePlanetService()
        {
            var planetService = new PlanetService();
            return planetService;
        }
        [HttpPost]
        public IHttpActionResult Create(PlanetCreateModel planetToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var planetService = CreatePlanetService();
            planetService.CreatePlanet(planetToCreate);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetList()
        {
            var planetService = CreatePlanetService();
            var planets = planetService.GetPlanets();
            return Ok(planets);
        }
        [HttpGet]
        public IHttpActionResult GetDetailById(int planetId)
        {
            var planetService = CreatePlanetService();
            return Ok(planetService.GetPlanetDetailById(planetId));
        }
        [HttpPut]
        public IHttpActionResult Update(PlanetUpdateModel planetToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var planetService = CreatePlanetService();
            planetService.UpdatePlanet(planetToUpdate);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(PlanetDeleteModel planetToDelete)
        {
            var planetService = CreatePlanetService();
            planetService.DeletePlanet(planetToDelete);
            return Ok();
        }
    }
}
