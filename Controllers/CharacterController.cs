using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using DICE_CharacterTracker.Data;
using DICE_CharacterTracker.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DICE_CharacterTracker.Controllers
{
    public class CharacterController : ControllerBase
    {
        private DiceDbContext _dbContext;

        public CharacterController(DiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create

        public Character CreateCharacter(Character newCharacter)
        {
            throw new NotImplementedException();
        }
        
        // Read

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        // GET: api/Character/user/5
        [HttpGet("api/Character/user/{id}")]
        public async Task<ActionResult<List<Character>>> GetCharactersForUserId(string id)
        {
            var characters = await _dbContext.Characters.Where(character => character.UserId == id).ToListAsync();

            if (!characters.Any())
            {
                return NotFound();
            }

            return characters;
        }

        // GET: api/Character/5
        [HttpGet("{id:int}")]
        public Character GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }
        
        // Update

        public Character UpdateCharacter(int id, Character character)
        {
            throw new NotImplementedException();
        }
        
        // Delete

        public Character DeleteCharacter(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}