using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetTemplate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
    }
}