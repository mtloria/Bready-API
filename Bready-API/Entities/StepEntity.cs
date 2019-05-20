namespace BreadyAPI.Entities
{
    public class StepEntity
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public int RecipeId { get; set; }
        public string Text { get; set; }
        public decimal TimeToNextStep { get; set; }
        public string AdditionalText { get; set; }
    }
}
