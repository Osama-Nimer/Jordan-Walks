namespace Jordan_Walks.API.Models.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LenghtInKm { get; set; }
        public string? WalkImgURL { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }


        public Difficulty Difficulty{ get; set; }
        public Rejon Rejon { get; set; }
    }
}
