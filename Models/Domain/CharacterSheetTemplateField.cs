using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetTemplateField
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CharacterSheetTemplate")]
        public int CharacterSheetTemplateId { get; set; }
        public CharacterSheetTemplate CharacterSheetTemplate { get; set; }
    }
}