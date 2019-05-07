using BreadyAPI.Entities;

namespace BreadyAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public int BreadId { get; set; }
        public int Flour { get; set; }
        public int? Flour2 { get; set; }
        public string FlourTypes { get; set; }
        public int Water { get; set; }
        public int WaterTemp { get; set; }
        public int Salt { get; set; }
        public int? Yeast { get; set; }
        public decimal? YeastTsp { get; set; }
        public int? Starter { get; set; }
        public decimal BulkFermentTime { get; set; }
        public decimal ProofTime { get; set; }
        public int OvenTemp { get; set; }
        public decimal BakeTime { get; set; }
        public decimal MixTime { get; set; }

        public Recipe(RecipeEntity entity)
        {
            Id = entity.Id;
            BreadId = entity.BreadId;
            Flour = entity.Flour;
            Flour2 = entity.Flour2;
            FlourTypes = entity.FlourTypes;
            Water = entity.Water;
            WaterTemp = entity.WaterTemp;
            Salt = entity.Salt;
            Yeast = entity.Yeast;
            YeastTsp = entity.YeastTsp;
            Starter = entity.Starter;
            BulkFermentTime = entity.BulkFermentTime;
            ProofTime = entity.ProofTime;
            OvenTemp = entity.OvenTemp;
            BakeTime = entity.BakeTime;
            MixTime = entity.MixTime;
        }
    }
}
