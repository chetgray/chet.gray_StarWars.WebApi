namespace StarWars.Data.DTOs
{
    /// <summary>
    ///     Represents character data to transfer between the data layer and the business layer.
    /// </summary>
    public class CharacterDTO
    {
        /// <summary>Gets or sets the character's ID.</summary>
        /// <value>A unique <see cref="int">integer</see> assigned by the database.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the character's name.</summary>
        /// <value>
        ///     A unique unicode <see cref="string">string</see>, maximum 850 characters.
        /// </value>
        public string Name { get; set; }

        /// <summary>Gets or sets the character's allegiance.</summary>
        /// <value>An <see cref="int">integer</see> referencing an allegiance record.</value>
        public int AllegianceId { get; set; }

        /// <summary>Gets or sets whether is a Jedi.</summary>
        /// <value>
        ///      A <see cref="bool">boolean</see> value indicating if the character is a Jedi.
        /// </value>
        public bool IsJedi { get; set; }

        /// <summary>Gets or sets the trilogy the character was introduced in.</summary>
        /// <value>An <see cref="int">integer</see> referencing an trilogy record.</value>
        public int TrilogyIntroducedInId { get; set; }
    }
}
