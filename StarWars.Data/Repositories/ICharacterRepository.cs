using System.Collections.Generic;

using StarWars.Data.DTOs;

namespace StarWars.Data.Repositories
{
    public interface ICharacterRepository
    {
        /// <summary>Gets all <see cref="CharacterDTO">character</see>s.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterDTO}">collection</see> of all
        ///     <see cref="CharacterDTO">character</see>s.
        /// </returns>
        IEnumerable<CharacterDTO> GetAll();

        /// <summary>
        ///     Gets the <see cref="CharacterDTO">character</see> with the specified
        ///     <paramref name="id">ID</paramref>.
        /// </summary>
        /// <param name="id">The <see cref="CharacterDTO.Id">ID</see> to filter for.</param>
        /// <returns>
        ///     The <see cref="CharacterDTO">character</see> with the specified
        ///     <paramref name="id">ID</paramref>, or <c><see langword="null">null</see></c> if none
        ///     exists.
        /// </returns>
        CharacterDTO GetById(int id);

        /// <summary>
        ///     Gets the first <see cref="CharacterDTO">character</see> with the specified
        ///     <paramref name="name">name</paramref>.
        /// </summary>
        /// <param name="name">The <see cref="CharacterDTO.Name">name</see> to filter for.</param>
        /// <returns>
        ///     The first <see cref="CharacterDTO">character</see> with the specified
        ///     <paramref name="name">name</paramref>, or <c><see langword="null">null</see></c> if none
        ///     is found.
        /// </returns>
        CharacterDTO GetOneByName(string name);

        /// <summary>
        ///    Gets all <see cref="CharacterDTO">character</see>s with the specified
        ///    <paramref name="allegianceId">allegiance ID</paramref>.
        /// </summary>
        /// <param name="allegianceId">
        ///     The <see cref="CharacterDTO.AllegianceId">allegiance ID</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterDTO">character</see>s with the specified
        ///     <paramref name="allegiance">allegiance ID</paramref>.
        /// </returns>
        IEnumerable<CharacterDTO> GetAllByAllegianceId(int allegianceId);

        /// <summary>Gets all <see cref="CharacterDTO">character</see>s that are Jedi.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterDTO}">collection</see> of all
        ///     <see cref="CharacterDTO">character</see>s that are Jedi.
        /// </returns>
        IEnumerable<CharacterDTO> GetAllJedi();

        /// <summary>
        ///     Gets all <see cref="CharacterDTO">character</see>s that are introduced in the trilogy
        ///     with the specified <paramref name="trilogyId">trilogy ID</paramref>.
        /// </summary>
        /// <param name="trilogyId">
        ///     The <see cref="CharacterDTO.TrilogyIntroducedInId">trilogy ID</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterDTO}">collection</see> of all
        ///     <see cref="CharacterDTO">character</see>s that are introduced in the trilogy with the
        ///     specified <paramref name="trilogyId">trilogy ID</paramref>.
        /// </returns>
        IEnumerable<CharacterDTO> GetAllByTrilogyId(int trilogyId);

        /// <summary>
        ///     Adds a new <see cref="CharacterDTO">character</see> to the collection.
        /// </summary>
        /// <param name="dto">
        ///     The <see cref="CharacterDTO">character</see> to add to the collection.
        /// </param>
        /// <returns>
        ///     The <see cref="CharacterDTO">character</see> that was added to the collection, or
        ///     <c><see langword="null">null</see></c> if the
        ///     <paramref name="dto">character</paramref> was not added.
        /// </returns>
        CharacterDTO Add(CharacterDTO dto);
    }
}
