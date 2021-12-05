using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetState
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Character")]
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        [ForeignKey("CharacterSheetTemplate")]
        public int CharacterSheetTemplateId { get; set; }
        public CharacterSheetTemplate CharacterSheetTemplate { get; set; }
        public string Name { get; set; }
        public DateTime StateCreated { get; set; }
        public DateTime StateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}