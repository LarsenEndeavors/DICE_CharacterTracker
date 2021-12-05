using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CharacterSheetTemplateField
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CharacterSheetTemplate")]
        public int CharacterSheetTemplateId { get; set; }
        public CharacterSheetTemplate CharacterSheetTemplate { get; set; }
    }
}