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
    public class ShipService : IShipService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateShip(ShipCreateModel shipToCreate)
        {
            var entity = new Ship()
            {
                ShipName = shipToCreate.ShipName,
                ShipModel = shipToCreate.ShipModel,
                ShipManufacturer = shipToCreate.ShipManufacturer,
                ShipLength = shipToCreate.ShipLength,
                ShipMaxSpeed = shipToCreate.ShipMaxSpeed
    };
            _ctx.Ships.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteShip(ShipDeleteModel shipToDelete)
        {
            var entity = _ctx.Ships.Single(e => e.ShipId == shipToDelete.ShipId);
            _ctx.Ships.Remove(entity);
            _ctx.SaveChanges();
        }

        public ShipDetailModel GetShipDetailById(int shipId)
        {
            var i = _ctx.Ships.Single(e => e.ShipId == shipId);
            var entity = new ShipDetailModel()
            {
                ShipId = i.PlanetId,
                ShipName = i.ShipName,
                ShipModel = i.ShipModel,
                ShipManufacturer = i.ShipManufacturer,
                ShipLength = i.ShipLength,
                ShipMaxSpeed = i.ShipMaxSpeed
            };
            return entity;
        }

        public IEnumerable<ShipListItem> GetShips()
        {
            var returnList = _ctx.Ships.Select(e => new ShipListItem()
            {
                ShipId = e.ShipId,
                ShipName = e.ShipName,
                ShipDescription = e.ShipDescription
            }).ToList();
            return returnList;
        }

        public void UpdateShip(ShipUpdateModel shipToUpdate)
        {
            var entity = _ctx.Ships.Single(e => e.ShipId == shipToUpdate.ShipId);
            if (entity != null)
            {
                if (shipToUpdate.UpdatedShipName != null)
                    entity.ShipName = shipToUpdate.UpdatedShipName;
                if (shipToUpdate.UpdatedShipModel != null)
                    entity.ShipModel = shipToUpdate.UpdatedShipModel;
                if (shipToUpdate.UpdatedShipManufacturer != null)
                    entity.ShipManufacturer = shipToUpdate.UpdatedShipManufacturer;
                if (shipToUpdate.UpdatedShipLength != null)
                    entity.ShipLength = (int)shipToUpdate.UpdatedShipLength;
                if (shipToUpdate.UpdatedShipMaxSpeed != null)
                    entity.ShipMaxSpeed = (int)shipToUpdate.UpdatedShipMaxSpeed;
                _ctx.SaveChanges();
            }
        }
    }
}