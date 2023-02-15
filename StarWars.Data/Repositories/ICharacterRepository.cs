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
    }
}
