namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetTemplateField
    {
        private int Id { get; set; }
        private int CharacterSheetTemplateId { get; set; }
        private CharacterSheetTemplate CharacterSheetTemplate { get; set; }
    }
}