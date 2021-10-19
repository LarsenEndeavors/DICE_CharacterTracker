using System;

namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetState
    {
        private int Id { get; set; }
        private int CharacterId { get; set; }
        private Character Character { get; set; }
        private int CharacterSheetTemplateId { get; set; }
        private CharacterSheetTemplate CharacterSheetTemplate { get; set; }
        private DateTime StateCreated { get; set; }
        private DateTime StateUpdated { get; set; }
        private string CreatedBy { get; set; }
        private string UpdatedBy { get; set; }
    }
}