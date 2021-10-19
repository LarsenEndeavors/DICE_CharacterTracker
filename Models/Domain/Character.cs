namespace DICE_CharacterTracker.Models.Domain
{
    public class Character
    {
        private int Id { get; set; }
        private int GameId { get; set; }
        private Game Game { get; set; }
        private string Name { get; set; }
        private string UserId { get; set; }
        private ApplicationUser User { get; set; }
    }
}