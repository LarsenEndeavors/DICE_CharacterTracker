using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetStateField
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("CharacterSheetState")]
        public int CharacterSheetStateId { get; set; }
        public CharacterSheetState CharacterSheetState { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("CharacterSheetTemplateField")]
        public int CharacterSheetTemplateFieldId { get; set; }
        public CharacterSheetTemplateField CharacterSheetTemplateField { get; set; }
        public string Value { get; set; }
    }
}