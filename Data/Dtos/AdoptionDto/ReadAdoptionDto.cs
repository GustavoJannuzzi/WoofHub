namespace WoofHub_App.Data.Dtos.AdoptionDto
{
    public class ReadAdoptionDto
    {
        public int Id { get; set;}
        public DateTime DateAdoption { get; set; }
        public int ClientId { get; set; }
        public int AnimalId { get; set; }
    }
}