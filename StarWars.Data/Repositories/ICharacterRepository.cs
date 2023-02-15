using System.Collections.Generic;

using StarWars.Data.DTOs;

namespace StarWars.Data.Repositories
{
    public interface ICharacterRepository
    {
        List<CharacterDTO> GetAll();
    }
}
