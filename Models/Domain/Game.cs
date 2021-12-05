using System.ComponentModel.DataAnnotations;

namespace DICE_CharacterTracker.Models.Domain
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}