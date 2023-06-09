﻿using System.Collections.Generic;
using System.Web.Http;

using StarWars.WebApi.Business;
using StarWars.WebApi.Models;

namespace StarWars.WebApi.Controllers
{
    public class CharactersController : ApiController
    {
        private ICharacterBLL _bll = new CharacterBLL();

        // GET api/Characters
        /// <inheritdoc cref="ICharacterBLL.GetAll"/>
        /// <summary>Gets all <see cref="CharacterModel">character</see>s.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all <see
        ///     cref="CharacterModel">character</see>s.
        /// </returns>
        public IEnumerable<CharacterModel> Get()
        {
            return _bll.GetAll();
        }

        // GET api/Characters/ById/{id}
        /// <inheritdoc cref="ICharacterBLL.GetById(int)"/>
        /// <summary>
        ///     Gets the <see cref="CharacterModel">character</see> with the specified <paramref
        ///     name="id">ID</paramref>.
        /// </summary>
        /// <param name="id">The <see cref="CharacterModel.Id">ID</see> to filter for.</param>
        /// <returns>
        ///     The <see cref="CharacterModel">character</see> with the specified <paramref
        ///     name="id">ID</paramref>, or <c><see langword="null">null</see></c> if none
        ///     exists.
        /// </returns>
        [Route("api/Characters/ById/{id}")]
        public CharacterModel GetById(int id)
        {
            return _bll.GetById(id);
        }

        // GET api/Characters/ByName/{name}
        /// <inheritdoc cref="ICharacterBLL.GetOneByName(string)"/>
        /// <summary>
        ///     Gets the first <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>.
        /// </summary>
        /// <param name="name">
        ///     The <see cref="CharacterModel.Name">name</see> to filter for.
        /// </param>
        /// <returns>
        ///     The first <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>, or <c><see langword="null">null</see></c>
        ///     if none is found.
        /// </returns>
        [Route("api/Characters/ByName/{name}")]
        public CharacterModel GetByName(string name)
        {
            return _bll.GetOneByName(name);
        }

        // GET api/Characters/AllByAllegiance/{allegiance}
        /// <inheritdoc cref="ICharacterBLL.GetAllByAllegiance(Allegiance)"/>
        /// <summary>
        ///    Gets all <see cref="CharacterModel">character</see>s with the specified <paramref
        ///    name="allegiance">allegiance</paramref>.
        /// </summary>
        /// <param name="allegiance">
        ///     The <see cref="CharacterModel.Allegiance">allegiance</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all <see
        ///     cref="CharacterModel">character</see>s with the specified <paramref
        ///     name="allegiance">allegiance</paramref>.
        /// </returns>
        [Route("api/Characters/AllByAllegiance/{allegiance}")]
        public IEnumerable<CharacterModel> GetAllByAllegiance(Allegiance? allegiance)
        {
            if (allegiance is null)
            {
                return new List<CharacterModel>();
            }
            return _bll.GetAllByAllegiance((Allegiance)allegiance);
        }

        // GET api/Characters/AllegianceByName/{name}
        /// <summary>
        ///     Gets the <see cref="CharacterModel.Allegiance">allegiance</see> of the first
        ///     <see cref="CharacterModel">character</see> with the specified <paramref
        ///     name="name">name</paramref>.
        /// </summary>
        /// <param name="name">The <see cref="CharacterModel.Name">name</see> to filter
        /// for.</param>
        /// <returns>
        ///     The <see cref="CharacterModel.Allegiance">allegiance</see> of the first <see
        ///     cref="CharacterModel">character</see> with the specified <paramref
        ///     name="name">name</paramref>, or <c><see langword="null">null</see></c> if none
        ///     is found.
        /// </returns>
        [Route("api/Characters/AllegianceByName/{name}")]
        public Allegiance? GetAllegianceByName(string name)
        {
            return _bll.GetOneByName(name)?.Allegiance;
        }

        // GET api/Characters/AllJedi
        /// <inheritdoc cref="ICharacterBLL.GetAllJedi"/>
        /// <summary>
        ///     Gets all <see cref="CharacterModel">character</see>s that are Jedi.
        /// </summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all <see
        ///     cref="CharacterModel">character</see>s that are Jedi.
        /// </returns>
        [Route("api/Characters/AllJedi")]
        public IEnumerable<CharacterModel> GetAllJedi()
        {
            return _bll.GetAllJedi();
        }

        // GET api/Characters/AllByTrilogy/{trilogy}
        /// <inheritdoc cref="ICharacterBLL.GetAllByTrilogy(Trilogy)"/>
        /// <summary>
        ///     Gets all <see cref="CharacterModel">character</see>s that are introduced in the
        ///     specified <paramref name="trilogy">trilogy</paramref>.
        /// </summary>
        /// <param name="trilogy">
        ///     The <see cref="CharacterModel.TrilogyIntroducedIn">trilogy</see> to filter for.
        /// </param>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all <see
        ///     cref="CharacterModel">character</see>s that are introduced in the specified
        ///     <paramref name="trilogy">trilogy</paramref>.
        /// </returns>
        [Route("api/Characters/AllByTrilogy/{trilogy}")]
        public IEnumerable<CharacterModel> GetAllByTrilogy(Trilogy? trilogy)
        {
            if (trilogy is null)
            {
                return new List<CharacterModel>();
            }
            return _bll.GetAllByTrilogy((Trilogy)trilogy);
        }

        // POST api/Characters
        /// <inheritdoc cref="ICharacterBLL.Add(CharacterModel)"/>
        /// <summary>
        ///     Adds a new <see cref="CharacterModel">character</see> to the collection.
        /// </summary>
        /// <param name="character">
        ///     The <see cref="CharacterModel">character</see> to add to the collection.
        /// </param>
        /// <returns>
        ///     The <see cref="CharacterModel">character</see> that was added to the collection,
        ///     or <c><see langword="null">null</see></c> if the <paramref
        ///     name="character">character</paramref> was not added.
        /// </returns>
        public CharacterModel Post([FromBody] CharacterModel character)
        {
            if (character is null)
            {
                return null;
            }
            CharacterModel addedCharacter = _bll.Add(character);
            return addedCharacter;
        }
    }
}
