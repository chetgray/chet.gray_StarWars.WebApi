using System;
using System.Collections.Generic;

using StarWars.WebApi.Models;

namespace StarWars.WebApi.Business
{
    public class CharacterBLL : ICharacterBLL
    {
        /// <summary>
        ///     The store of <see cref="CharacterModel">character</see>s.
        /// </summary>
        /// <remarks>The key should be the same as the <see cref="CharacterModel.Id">ID</see></remarks>
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

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAll()
        {
            return _characters.Values;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public CharacterModel GetOneByName(string name)
        {
            foreach (CharacterModel character in _characters.Values)
            {
                if (character.Name == name)
                {
                    return character;
                }
            }
            return null;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAllByTrilogy(Trilogy? trilogy)
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

        /// <inheritdoc/>
        public CharacterModel Add(CharacterModel character)
        {
            try
            {
                _characters.Add(character.Id, character);
            }
            catch (ArgumentException)
            {
                return null;
            }
            return GetById(character.Id);
        }
    }
}
