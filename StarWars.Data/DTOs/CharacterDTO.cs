namespace StarWars.Data.DTOs
{
    public class CharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AllegianceId { get; set; }
        public bool IsJedi { get; set; }
        public int TrilogyIntroducedInId { get; set; }
    }
}
