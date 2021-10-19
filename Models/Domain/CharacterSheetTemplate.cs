namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetTemplate
    {
        private int Id { get; set; }
        private int GameId { get; set; }
        private Game Game { get; set; }
        private string Name { get; set; }
    }
}