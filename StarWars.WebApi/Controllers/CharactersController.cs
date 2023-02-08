using System.Collections.Generic;
using System.Web.Http;

using StarWars.WebApi.Models;

namespace StarWars.WebApi.Controllers
{
    public class CharactersController : ApiController
    {
        private Dictionary<int, CharacterModel> _characters = new Dictionary<
            int,
            CharacterModel
        >
        {
            {
                1,
                new CharacterModel()
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = true,
                    TrilogyIntroducedIn = Trilogy.Original
                }
            },
            {
                2,
                new CharacterModel()
                {
                    Id = 2,
                    Name = "Obi-Wan Kenobi",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = true,
                    TrilogyIntroducedIn = Trilogy.Original
                }
            },
            {
                3,
                new CharacterModel()
                {
                    Id = 3,
                    Name = "Jar Jar Binks",
                    Allegiance = Allegiance.None,
                    IsJedi = false,
                    TrilogyIntroducedIn = Trilogy.Prequel
                }
            },
            {
                4,
                new CharacterModel()
                {
                    Id = 4,
                    Name = "Poe Dameron",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = false,
                    TrilogyIntroducedIn = Trilogy.Sequel
                }
            },
            {
                5,
                new CharacterModel()
                {
                    Id = 5,
                    Name = "Finn",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = false,
                    TrilogyIntroducedIn = Trilogy.Sequel
                }
            },
            {
                6,
                new CharacterModel()
                {
                    Id = 6,
                    Name = "Rey Skywalker",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = true,
                    TrilogyIntroducedIn = Trilogy.Sequel
                }
            },
            {
                7,
                new CharacterModel()
                {
                    Id = 7,
                    Name = "C-3PO",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = false,
                    TrilogyIntroducedIn = Trilogy.Original
                }
            },
            {
                8,
                new CharacterModel()
                {
                    Id = 8,
                    Name = "R2-D2",
                    Allegiance = Allegiance.Rebellion,
                    IsJedi = false,
                    TrilogyIntroducedIn = Trilogy.Original
                }
            },
        };

        // GET api/Characters/All
        /// <summary>Gets all <see cref="CharacterModel">character</see>s.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s.
        /// </returns>
        [Route("api/Characters/All")]
        public IEnumerable<CharacterModel> GetAll()
        {
            return _characters.Values;
        }

        // GET api/Characters/ById/{id}
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
        [Route("api/Characters/ById/{id}")]
        public CharacterModel GetById(int id)
        {
            try
            {
                return _characters[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        // GET api/Characters/AllegianceByName/{name}
        /// <summary>
        ///     Gets the <see cref="CharacterModel.Allegiance">allegiance</see> of the first
        ///     <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>.
        /// </summary>
        /// <param name="name">The <see cref="CharacterModel.Name">name</see> to filter for.</param>
        /// <returns>
        ///     The <see cref="CharacterModel.Allegiance">allegiance</see> of the first
        ///     <see cref="CharacterModel">character</see> with the specified
        ///     <paramref name="name">name</paramref>, or <c><see langword="null">null</see></c> if none
        ///     is found.
        /// </returns>
        [Route("api/Characters/AllegianceByName/{name}")]
        public Allegiance? GetAllegianceByName(string name)
        {
            foreach (CharacterModel character in _characters.Values)
            {
                if (character.Name == name)
                {
                    return character.Allegiance;
                }
            }
            return null;
        }

        // GET api/Characters/AllJedi
        /// <summary>Gets all <see cref="CharacterModel">character</see>s that are Jedi.</summary>
        /// <returns>
        ///     A <see cref="IEnumerable{CharacterModel}">collection</see> of all
        ///     <see cref="CharacterModel">character</see>s that are Jedi.
        /// </returns>
        [Route("api/Characters/AllJedi")]
        public IEnumerable<CharacterModel> GetAllJedi()
        {
            List<CharacterModel> jedi = new List<CharacterModel>();
            foreach (CharacterModel character in _characters.Values)
            {
                if (character.IsJedi)
                {
                    jedi.Add(character);
                }
            }
            return jedi;
        }

        // GET api/Characters/ByTrilogy/{trilogy}
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
        [Route("api/Characters/ByTrilogy/{trilogy}")]
        public IEnumerable<CharacterModel> GetByTrilogy(Trilogy? trilogy)
        {
            List<CharacterModel> characters = new List<CharacterModel>();
            if (trilogy is null)
            {
                return characters;
            }
            foreach (CharacterModel character in _characters.Values)
            {
                if (character.TrilogyIntroducedIn == trilogy)
                {
                    characters.Add(character);
                }
            }
            return characters;
        }
    }
}
