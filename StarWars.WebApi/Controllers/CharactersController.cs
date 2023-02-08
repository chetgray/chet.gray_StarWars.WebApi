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
        /// <summary>
        /// Gets all of the <see cref="CharacterModel"/>s.
        /// </summary>
        /// <returns>An <see cref="IEnumerable"/> of all <see cref="CharacterModel"/>s.</returns>
        [Route("api/Characters/All")]
        public IEnumerable<CharacterModel> GetAll()
        {
            return _characters.Values;
        }

        // GET api/Characters/ById/{id}
        /// <summary>
        /// Gets the <see cref="CharacterModel"/> with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The <see cref="CharacterModel.Id"/> to filter for.</param>
        /// <returns>The <see cref="CharacterModel"/> with the specified <paramref name="id"/>.</returns>
        [Route("api/Characters/ById/{id}")]
        public CharacterModel GetById(int id)
        {
            return _characters[id];
        }
    }
}
