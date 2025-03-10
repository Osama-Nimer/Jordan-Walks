namespace Jordan_Walks.API.Models.Domain
{
    public class Rejon
    {
        public Guid Id { get; set; }

        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string? ImgURL { get; set; }
    }
}
