using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using StarWars.Data.DataAccess;
using StarWars.Data.DTOs;

namespace StarWars.Data.Repositories
{
    /// <inheritdoc cref="ICharacterRepository"/>
    public class CharacterRepository : ICharacterRepository
    {
        private readonly IDAL _dal;

        /// <summary>
        ///     Initializes a new <see cref="CharacterRepository">CharacterRepository</see>
        ///     instance with the default <see cref="DAL">DAL</see> backend.
        /// </summary>
        public CharacterRepository()
            : this(
                new DAL(
                    ConfigurationManager.ConnectionStrings["StarWars.Data"].ConnectionString
                )
            )
        { }

        /// <summary>
        ///     Initializes a new <see cref="CharacterRepository">CharacterRepository</see>
        ///     instance with the passed <paramref name="dal">DAL</paramref> as the backend.
        /// </summary>
        /// <param name="dal">The <see cref="IDAL">DAL</see> to use as the backend.</param>
        public CharacterRepository(IDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterDTO> GetAll()
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAll",
                new Dictionary<string, object>()
            );
            return ConvertManyToDtos(table);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public IEnumerable<CharacterDTO> GetAllByAllegianceId(int allegianceId)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllByAllegianceId",
                new Dictionary<string, object> { { "@CharacterAllegianceId", allegianceId } }
            );
            return ConvertManyToDtos(table);
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterDTO> GetAllJedi()
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllJedi",
                new Dictionary<string, object>()
            );
            return ConvertManyToDtos(table);
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterDTO> GetAllByTrilogyId(int trilogyId)
        {
            DataTable table = _dal.GetTableFromStoredProcedure(
                "spA_Character_GetAllByTrilogyId",
                new Dictionary<string, object> { { "@CharacterTrilogyId", trilogyId } }
            );
            return ConvertManyToDtos(table);
        }

        /// <inheritdoc/>
        public CharacterDTO Add(CharacterDTO dto)
        {
            DataTable table;
            try
            {
                table = _dal.GetTableFromStoredProcedure(
                    "spA_Character_Add",
                    new Dictionary<string, object>
                    {
                    { "@CharacterName", dto.Name },
                    { "@CharacterAllegianceId", dto.AllegianceId },
                    { "@CharacterIsJedi", dto.IsJedi },
                    { "@CharacterTrilogyIntroducedInId", dto.TrilogyIntroducedInId },
                    }
                );
            }
            catch (SqlException)
            {
                return null;
            }
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return ConvertToDto(table.Rows[0]);
        }

        /// <summary>
        ///     Creates a <see cref="CharacterDTO">character DTO</see> from the data in the
        ///     passed <paramref name="row">data row</paramref>.
        /// </summary>
        /// <param name="row">A <see cref="DataRow">data row</see> with character data.</param>
        /// <returns>
        ///     A <see cref="CharacterDTO">character DTO</see> with the data from the passed
        ///     <paramref name="row">data row</paramref>.
        /// </returns>
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

        /// <summary>
        ///     Creates a collection of <see cref="CharacterDTO">character DTOs</see> from the
        ///     data in the passed <paramref name="table">data table</paramref>.
        /// </summary>
        /// <param name="table">
        ///     A <see cref="DataTable">data table</see> with character data.
        /// </param>
        /// <returns>
        ///     A collection of <see cref="CharacterDTO">character DTOs</see> with the data from
        ///     the passed <paramref name="table">data table</paramref>.
        /// </returns>
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
