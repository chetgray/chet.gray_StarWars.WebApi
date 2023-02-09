using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarWars.WebApi.Models
{
    // Serialize to string value
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Allegiance
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Rebellion")]
        Rebellion,

        [EnumMember(Value = "Empire")]
        Empire,
    }

    // Serialize to string value
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Trilogy
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Original")]
        Original,

        [EnumMember(Value = "Prequel")]
        Prequel,

        [EnumMember(Value = "Sequel")]
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
