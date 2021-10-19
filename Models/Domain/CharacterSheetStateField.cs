namespace DICE_CharacterTracker.Models.Domain
{
    public class CharacterSheetStateField
    {
        private int CharacterSheetStateId { get; set; }
        private CharacterSheetState CharacterSheetState { get; set; }
        private int CharacterSheetTemplateFieldId { get; set; }
        private CharacterSheetTemplateField CharacterSheetTemplateField { get; set; }
        private string Value { get; set; }
    }
}