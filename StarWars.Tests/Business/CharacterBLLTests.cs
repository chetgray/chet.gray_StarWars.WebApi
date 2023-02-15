using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StarWars.Data.DTOs;
using StarWars.WebApi.Business;
using StarWars.WebApi.Models;

namespace StarWars.Tests.Business
{
    [TestClass]
    public class CharacterBLLTests
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(1700)]
        public void TestGetAllReturnsSameNumberOfModelsAsDtos(int dtoCount)
        {
            // Arrange
            CharacterRepositoryStub repository = new CharacterRepositoryStub();
            for (int i = 0; i < dtoCount; i++)
            {
                repository.testDtos.Add(new CharacterDTO());
            }
            CharacterBLL bll = new CharacterBLL(repository);

            // Act
            List<CharacterModel> models = bll.GetAll().ToList();

            // Assert
            Assert.AreEqual(dtoCount, models.Count);
        }

        [TestMethod]
        public void TestGetAllReturnsSameDataAsInDtos()
        {
            // Arrange
            List<CharacterDTO> testDtos = new List<CharacterDTO>
            {
                new CharacterDTO
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    AllegianceId = 1,
                    IsJedi = true,
                    TrilogyIntroducedInId = 1,
                },
                new CharacterDTO
                {
                    Id = 11,
                    Name = "Kylo Ren",
                    AllegianceId = 2,
                    IsJedi = false,
                    TrilogyIntroducedInId = 3,
                },
                new CharacterDTO
                {
                    Id = 111,
                    Name = "Jar Jar Binks",
                    AllegianceId = 0,
                    IsJedi = false,
                    TrilogyIntroducedInId = 2,
                }
            };
            CharacterRepositoryStub repository = new CharacterRepositoryStub
            {
                testDtos = testDtos.ToList(),
            };
            CharacterBLL bll = new CharacterBLL(repository);

            // Act
            List<CharacterModel> resultModels = bll.GetAll().ToList();

            // Assert
            for (int i = 0; i < Math.Max(testDtos.Count, resultModels.Count); i++)
            {
                CharacterDTO dto = testDtos[i];
                CharacterModel model = resultModels[i];
                Assert.AreEqual(dto.Id, model.Id);
                Assert.AreEqual(dto.Name, model.Name);
                Assert.AreEqual(dto.AllegianceId, (int)model.Allegiance);
                Assert.AreEqual(dto.IsJedi, model.IsJedi);
                Assert.AreEqual(dto.TrilogyIntroducedInId, (int)model.TrilogyIntroducedIn);
            }
        }
    }
}
