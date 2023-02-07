namespace StarWars.WebApi.Models
{
    public enum Allegiance
    {
        None = 0,
        Rebel,
        Empire,
    }

    public enum Trilogy
    {
        None = 0,
        Original,
        Prequel,
        Sequel,
    }

    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Allegiance Allegiance { get; set; }
        public bool IsJedi { get; set; }
        public Trilogy TrilogyIntroducedIn { get; set; }
    }
}
