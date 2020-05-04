using Contracts;
using Data;
using Data.Entities;
using Models.PlanetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PlanetService : IPlanetService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreatePlanet(PlanetCreateModel planetToCreate)
        {
            var entity = new Planet()
            {
                PlanetName = planetToCreate.PlanetName,
                PlanetDescription = planetToCreate.PlanetDescription,
                PlanetClimate = planetToCreate.PlanetClimate,
                HoursPerDay = planetToCreate.HoursPerDay,
                DaysPerYear = planetToCreate.DaysPerYear,
                NumberOfSuns = planetToCreate.NumberOfSuns,
                NumberOfMoons = planetToCreate.NumberOfMoons
            };
            _ctx.Planets.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeletePlanet(PlanetDeleteModel planetToDelete)
        {
            var entity = _ctx.Planets.Single(e => e.PlanetId == planetToDelete.PlanetId);
            _ctx.Planets.Remove(entity);
            _ctx.SaveChanges();
        }

        public PlanetDetailModel GetPlanetDetailById(int planetId)
        {
            var i = _ctx.Planets.Single(e => e.PlanetId == planetId);
            var entity = new PlanetDetailModel()
            {
                PlanetId = i.PlanetId,
                PlanetName = i.PlanetName,
                PlanetDescription = i.PlanetDescription,
                PlanetClimate = i.PlanetClimate,
                HoursPerDay = i.HoursPerDay,
                DaysPerYear = i.DaysPerYear,
                NumberOfSuns = i.NumberOfSuns,
                NumberOfMoons = i.NumberOfMoons
            };
            return entity;
        }

        public IEnumerable<PlanetListItem> GetPlanets()
        {
            var returnList = _ctx.Planets.Select(e => new PlanetListItem()
            {
                PlanetId = e.PlanetId,
                PlanetName = e.PlanetName,
                PlanetDescription = e.PlanetDescription
            }).ToList();
            return returnList;
        }

        public void UpdatePlanet(PlanetUpdateModel planetToUpdate)
        {
            var entity = _ctx.Planets.Single(e => e.PlanetId == planetToUpdate.PlanetId);
            if (entity != null)
            {
                if (planetToUpdate.UpdatedPlanetName != null)
                    entity.PlanetName = planetToUpdate.UpdatedPlanetName;
                if (planetToUpdate.UpdatedPlanetDescription != null)
                    entity.PlanetDescription = planetToUpdate.UpdatedPlanetDescription;
                if (planetToUpdate.UpdatedPlanetClimate != null)
                    entity.PlanetClimate = planetToUpdate.UpdatedPlanetClimate;
                if (planetToUpdate.UpdatedHoursPerDay != null)
                    entity.HoursPerDay = (int)planetToUpdate.UpdatedHoursPerDay;
                if (planetToUpdate.UpdatedDaysPerYear != null)
                    entity.DaysPerYear = (int)planetToUpdate.UpdatedDaysPerYear;
                if (planetToUpdate.UpdatedNumberOfSuns != null)
                    entity.NumberOfSuns = (int)planetToUpdate.UpdatedNumberOfSuns;
                if (planetToUpdate.UpdatedNumberOfMoons != null)
                    entity.NumberOfMoons = (int)planetToUpdate.UpdatedNumberOfMoons;
                _ctx.SaveChanges();
            }
        }
    }
}
