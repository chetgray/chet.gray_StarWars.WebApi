﻿using System.Collections.Generic;

using StarWars.Data.DTOs;
using StarWars.Data.Repositories;

namespace StarWars.Tests.Business
{
    internal class CharacterRepositoryStub : ICharacterRepository
    {
        public List<CharacterDTO> testDtos = new List<CharacterDTO>();

        public IEnumerable<CharacterDTO> GetAll()
        {
            return testDtos;
        }

        public CharacterDTO GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
