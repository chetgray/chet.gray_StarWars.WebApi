using System.Collections.Generic;

using StarWars.WebApi.Models;

namespace StarWars.WebApi.Business
{
    internal interface ICharacterBLL
    {
        /// <summary>Gets all <see cref="CharacterModel">character</see>s.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s.
        /// </returns>
        IEnumerable<CharacterModel> GetAll();

        /// <summary>
        ///     Gets the <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="id">ID</paramref>.
        /// </summary>
        /// <param name="id">The <see cref="CharacterModel.Id">ID</see> to filter for.</param>
        /// <returns>
        ///     The <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="id">ID</paramref>, or <c><see langword="null">null</see></c> if none
        ///     exists.
        /// </returns>
        CharacterModel GetById(int id);

        /// <summary>
        ///     Gets the first <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>.
        /// </summary>
        /// <param name="name">The <see cref="CharacterModel.Name">name</see> to filter for.</param>
        /// <returns>
        ///     The first <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>, or <c><see langword="null">null</see></c> if none
        ///     is found.
        /// </returns>
        CharacterModel GetOneByName(string name);

        /// <summary>
        ///    Gets all <see cref="CharacterModel">character</see>s with the specified
        ///    <paramref name="allegiance">allegiance</paramref>.
        /// </summary>
        /// <param name="allegiance">
        ///     The <see cref="CharacterModel.Allegiance">allegiance</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s with the specified
        ///     <paramref name="allegiance">allegiance</paramref>.
        /// </returns>
        IEnumerable<CharacterModel> GetAllByAllegiance(Allegiance allegiance);

        /// <summary>Gets all <see cref="CharacterModel">character</see>s that are Jedi.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s that are Jedi.
        /// </returns>
        IEnumerable<CharacterModel> GetAllJedi();

        /// <summary>
        ///     Gets all <see cref="CharacterModel">character</see>s that are introduced in the
        ///     specified <paramref name="trilogy">trilogy</paramref>.
        /// </summary>
        /// <param name="trilogy">
        ///     The <see cref="CharacterModel.TrilogyIntroducedIn">trilogy</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s that are introduced in the specified
        ///     <paramref name="trilogy">trilogy</paramref>.
        /// </returns>
        IEnumerable<CharacterModel> GetAllByTrilogy(Trilogy? trilogy);

        /// <summary>
        ///     Adds a new <see cref="CharacterModel">character</see> to the collection.
        /// </summary>
        /// <param name="character">
        ///     The <see cref="CharacterModel">character</see> to add to the collection.
        /// </param>
        /// <returns>
        ///     The <see cref="CharacterModel">character</see> that was added to the collection, or
        ///     <c><see langword="null">null</see></c> if the
        ///     <paramref name="character">character</paramref> was not added.
        /// </returns>
        CharacterModel Add(CharacterModel character);
    }
}
