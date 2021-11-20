using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DICE_CharacterTracker.Data;
using DICE_CharacterTracker.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public Task<ActionResult<CharacterSheetState>> CreateCharacterSheetState(CharacterSheetState newCharacterSheetState)
        {
            throw new NotImplementedException();
        }
        
        // Read

        public Task<ActionResult<List<CharacterSheetState>>> GetAllCharacterSheetStates()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<CharacterSheetState>>> GetCharacterSheetStatesForCharacterId(int characterId)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<CharacterSheetState>> GetCharacterSheetState(int id)
        {
            var characterSheetState = await _dbContext.CharacterSheetStates.FindAsync(id);
            if (characterSheetState == null)
            {
                return NotFound();
            }

            return characterSheetState;
        }
        
        // Update

        public Task<IActionResult> UpdateCharacterSheetState(CharacterSheetState characterSheetState)
        {
            throw new NotImplementedException();
        }
        
        // Delete

        public Task<ActionResult<CharacterSheetState>> DeleteCharacterSheetState(int id)
        {
            throw new NotImplementedException();
        }
    }
}