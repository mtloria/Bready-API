using System;
namespace BreadyAPI.Entities
{
    public class RecipeEntity
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
        public string StarterType { get; set; }
    }
}
