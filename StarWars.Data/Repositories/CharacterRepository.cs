using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using StarWars.Data.DataAccess;
using StarWars.Data.DTOs;

namespace StarWars.Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly IDAL _dal;

        /// <summary>
        ///     Initializes a new <see cref="CharacterRepository">CharacterRepository</see> instance
        ///     with the default <see cref="DAL">DAL</see> backend.
        /// </summary>
        public CharacterRepository()
            : this(
                new DAL(
                    ConfigurationManager.ConnectionStrings["StarWars.Data"].ConnectionString
                )
            )
        { }

        /// <summary>
        ///     Initializes a new <see cref="CharacterRepository">CharacterRepository</see> instance
        ///     with the passed <paramref name="dal">DAL</paramref> as the backend.
        /// </summary>
        /// <param name="dal">The <see cref="IDAL">DAL</see> to use as the backend.</param>
        public CharacterRepository(IDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public IEnumerable<CharacterDTO> GetAll()
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAll",
                new Dictionary<string, object>()
            );
            return ConvertManyToDtos(table);
        }

        public CharacterDTO GetById(int id)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetById",
                new Dictionary<string, object> { { "@CharacterId", id } }
            );
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return ConvertToDto(table.Rows[0]);
        }

        public CharacterDTO GetOneByName(string name)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllByName",
                new Dictionary<string, object> { { "@CharacterName", name } }
            );
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return ConvertToDto(table.Rows[0]);
        }

        public IEnumerable<CharacterDTO> GetAllByAllegianceId(int allegianceId)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllByAllegianceId",
                new Dictionary<string, object> { { "@CharacterAllegianceId", allegianceId } }
            );
            return ConvertManyToDtos(table);
        }

        public IEnumerable<CharacterDTO> GetAllByTrilogyId(int trilogyId)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllByTrilogyId",
                new Dictionary<string, object> { { "@CharacterTrilogyId", trilogyId } }
            );
            return ConvertManyToDtos(table);
        }

        private CharacterDTO ConvertToDto(DataRow row)
        {
            return new CharacterDTO()
            {
                Id = (int)row["CharacterId"],
                Name = (string)row["CharacterName"],
                AllegianceId = (int)row["CharacterAllegianceId"],
                IsJedi = (bool)row["CharacterIsJedi"],
                TrilogyIntroducedInId = (int)row["CharacterTrilogyIntroducedInId"]
            };
        }

        private IEnumerable<CharacterDTO> ConvertManyToDtos(DataTable table)
        {
            List<CharacterDTO> dtos = new List<CharacterDTO>();
            foreach (DataRow row in table.Rows)
            {
                dtos.Add(ConvertToDto(row));
            }
            return dtos;
        }
    }
}
