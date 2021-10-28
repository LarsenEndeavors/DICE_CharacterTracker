using System;
using System.Collections.Generic;
using DICE_CharacterTracker.Data;
using DICE_CharacterTracker.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DICE_CharacterTracker.Controllers
{
    public class CharacterSheetStateController : ControllerBase
    {
        private DiceDbContext _dbContext;

        public CharacterSheetStateController(DiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create

        public CharacterSheetState CreateCharacterSheetState(CharacterSheetState newCharacterSheetState)
        {
            throw new NotImplementedException();
        }
        
        // Read

        public List<CharacterSheetState> GetAllCharacterSheetStates()
        {
            throw new NotImplementedException();
        }

        public List<CharacterSheetState> GetCharacterSheetStatesForCharacterId(int characterId)
        {
            throw new NotImplementedException();
        }

        public CharacterSheetState GetCharacterSheetState(int id)
        {
            throw new NotImplementedException();
        }
        
        // Update

        public CharacterSheetState UpdateCharacterSheetState(CharacterSheetState characterSheetState)
        {
            throw new NotImplementedException();
        }
        
        // Delete

        public CharacterSheetState DeleteCharacterSheetState(int id)
        {
            throw new NotImplementedException();
        }
    }
}