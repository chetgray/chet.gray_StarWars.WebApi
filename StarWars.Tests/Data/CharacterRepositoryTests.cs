using System.Collections.Generic;
using System.Data;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StarWars.Data.Repositories;

namespace StarWars.Tests.Data
{
    [TestClass]
    public class CharacterRepositoryTests
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(1700)]
        public void TestGetAllReturnsSameNumberOfDtosAsRecordsInTable(int recordCount)
        {
            // Arrange
            DALStub dal = new DALStub() { testTable = CreateCharacterTable() };
            for (int i = 0; i < recordCount; i++)
            {
                dal.testTable.Rows.Add(i, string.Empty, 0, false, 0);
            }
            CharacterRepository repository = new CharacterRepository(dal);

            // Act
            List<StarWars.Data.DTOs.CharacterDTO> dtos = repository.GetAll().ToList();

            // Assert
            Assert.AreEqual(recordCount, dtos.Count);
        }

        [TestMethod]
        public void TestGetAllReturnsSameDataAsInTable()
        {
            // Arrange
            DALStub dal = new DALStub() { testTable = CreateCharacterTable() };
            dal.testTable.Rows.Add(1, "Luke Skywalker", 1, true, 1);
            dal.testTable.Rows.Add(11, "Kylo Ren", 2, false, 3);
            dal.testTable.Rows.Add(111, "Jar Jar Binks", 0, false, 2);
            CharacterRepository repository = new CharacterRepository(dal);

            // Act
            List<StarWars.Data.DTOs.CharacterDTO> dtos = repository.GetAll().ToList();

            // Assert
            Assert.AreEqual(1, dtos[0].Id);
            Assert.AreEqual("Luke Skywalker", dtos[0].Name);
            Assert.AreEqual(1, dtos[0].AllegianceId);
            Assert.AreEqual(true, dtos[0].IsJedi);
            Assert.AreEqual(1, dtos[0].TrilogyIntroducedInId);

            Assert.AreEqual(11, dtos[1].Id);
            Assert.AreEqual("Kylo Ren", dtos[1].Name);
            Assert.AreEqual(2, dtos[1].AllegianceId);
            Assert.AreEqual(false, dtos[1].IsJedi);
            Assert.AreEqual(3, dtos[1].TrilogyIntroducedInId);

            Assert.AreEqual(111, dtos[2].Id);
            Assert.AreEqual("Jar Jar Binks", dtos[2].Name);
            Assert.AreEqual(0, dtos[2].AllegianceId);
            Assert.AreEqual(false, dtos[2].IsJedi);
            Assert.AreEqual(2, dtos[2].TrilogyIntroducedInId);
        }

        private static DataTable CreateCharacterTable()
        {
            DataTable testTable = new DataTable();
            testTable.Columns.Add("CharacterId", typeof(int));
            testTable.Columns.Add("CharacterName", typeof(string));
            testTable.Columns.Add("CharacterAllegianceId", typeof(int));
            testTable.Columns.Add("CharacterIsJedi", typeof(bool));
            testTable.Columns.Add("CharacterTrilogyIntroducedInId", typeof(int));
            return testTable;
        }
    }
}
