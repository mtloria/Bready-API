using BreadyAPI.Entities;

namespace BreadyAPI.Models
{
    public class Step
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public int RecipeId { get; set; }
        public string Text { get; set; }
        public decimal TimeToNextStep { get; set; }
        public string AdditionalText { get; set; }

        public Step(StepEntity entity)
        {
            Id = entity.Id;
            StepNumber = entity.StepNumber;
            RecipeId = entity.RecipeId;
            Text = entity.Text;
            TimeToNextStep = entity.TimeToNextStep;
            AdditionalText = entity.AdditionalText;
        }
    }
}
