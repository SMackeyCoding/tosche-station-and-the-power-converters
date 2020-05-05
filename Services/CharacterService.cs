using Contracts;
using Data;
using Data.Entities;
using Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class CharacterService : ICharacterService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateCharacter(CharacterCreateModel characterToCreate)
        {
            var entity = new Character()
            {
                FirstName = characterToCreate.FirstName,
                LastName = characterToCreate.LastName,
                Race = characterToCreate.Race,
                Affiliation = characterToCreate.Affiliation,
                WeaponOfChoice = characterToCreate.WeaponOfChoice,
                PlanetId = characterToCreate.PlanetId,
                ShipId = characterToCreate.ShipId
            };
            _ctx.Characters.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteCharacter(CharacterDeleteModel characterToDelete)
        {
            var entity = _ctx.Characters.Single(e => e.CharacterId == characterToDelete.CharacterId);
            _ctx.Characters.Remove(entity);
            _ctx.SaveChanges();
        }

        public CharacterDetailModel GetCharacterDetailById(int characterId)
        {
            var i = _ctx.Characters.Single(e => e.CharacterId == characterId);
            var entity = new CharacterDetailModel()
            {
                CharacterId = i.CharacterId,
                FirstName = i.FirstName,
                LastName = i.LastName,
                Race = i.Race,
                Affiliation = i.Affiliation,
                WeaponOfChoice = i.WeaponOfChoice,
                PlanetId = i.PlanetId,
                ShipId = i.ShipId
            };
            return entity;
        }

        public IEnumerable<CharacterListModel> GetCharacters()
        {
            var returnList = _ctx.Characters.Select(e => new CharacterListModel()
            {
                CharacterId = e.CharacterId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Race = e.Race
            }).ToList();
            return returnList;
        }

        public void UpdateCharacter(CharacterUpdateModel characterToUpdate)
        {
            var entity = _ctx.Characters.Single(e => e.CharacterId == characterToUpdate.CharacterId);
            if (entity != null)
            {
                if (characterToUpdate.UpdatedFirstName != null)
                    entity.FirstName = characterToUpdate.UpdatedFirstName;
                if (characterToUpdate.UpdatedLastName != null)
                    entity.LastName = characterToUpdate.UpdatedLastName;
                if (characterToUpdate.UpdatedRace != null)
                    entity.Race = characterToUpdate.UpdatedRace;
                if (characterToUpdate.UpdatedAffiliation != null)
                    entity.Affiliation = characterToUpdate.UpdatedAffiliation;
                if (characterToUpdate.UpdatedWeaponOfChoice != null)
                    entity.WeaponOfChoice = characterToUpdate.UpdatedWeaponOfChoice;
                if (characterToUpdate.UpdatedPlanetId != null)
                    entity.PlanetId = (int)characterToUpdate.UpdatedPlanetId;
                if (characterToUpdate.UpdatedShipId != null)
                    entity.ShipId = (int)characterToUpdate.UpdatedShipId;
            }
        }
    }
}
