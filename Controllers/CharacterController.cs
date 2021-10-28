using System;
using System.Collections.Generic;
using DICE_CharacterTracker.Data;
using DICE_CharacterTracker.Models.Domain;
using Microsoft.AspNetCore.Mvc;

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

        public List<Character> GetCharactersForUserId(int id)
        {
            throw new NotImplementedException();
        }

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