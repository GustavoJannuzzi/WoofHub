namespace WoofHub_App.Data.Dtos.AdoptionDto
{
    public class CreateAdoptionDto
    {
        public DateTime DateAdoption { get; set; }
        public int ClientId { get; set; }
        public int AnimalId { get; set; }
    }
}