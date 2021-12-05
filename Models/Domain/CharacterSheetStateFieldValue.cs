using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CharacterSheetStateFieldValue
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [ForeignKey("CharacterSheetState")]
        public int CharacterSheetStateId { get; set; }
        public CharacterSheetState CharacterSheetState { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}