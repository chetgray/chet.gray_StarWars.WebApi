using System.Collections.Generic;

using StarWars.Data.DTOs;
using StarWars.Data.Repositories;
using StarWars.WebApi.Models;

namespace StarWars.WebApi.Business
{
    /// <inheritdoc cref="ICharacterBLL"/>
    public class CharacterBLL : ICharacterBLL
    {
        private readonly ICharacterRepository _repository;

        /// <summary>
        ///     Initializes a new <see cref="CharacterBLL">CharacterBLL</see> instance with the
        ///     default <see cref="CharacterRepository">repository</see> backend.
        /// </summary>
        public CharacterBLL() : this(new CharacterRepository()) { }

        /// <summary>
        ///     Initializes a new <see cref="CharacterBLL">CharacterBLL</see> instance with the
        ///     passed <paramref name="repository">repository</paramref> as the backend.
        /// </summary>
        /// <param name="repository">
        ///     The <see cref="ICharacterRepository">repository</see> to use as the backend.
        /// </param>
        public CharacterBLL(ICharacterRepository repository)
        {
            _repository = repository;
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAll()
        {
            IEnumerable<CharacterDTO> dtos = _repository.GetAll();
            return ConvertManyToModels(dtos);
        }

        /// <inheritdoc/>
        public CharacterModel GetById(int id)
        {
            CharacterDTO dto = _repository.GetById(id);
            return ConvertToModel(dto);
        }

        /// <inheritdoc/>
        public CharacterModel GetOneByName(string name)
        {
            CharacterDTO dto = _repository.GetOneByName(name);
            return ConvertToModel(dto);
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAllByAllegiance(Allegiance allegiance)
        {
            IEnumerable<CharacterDTO> dtos = _repository.GetAllByAllegianceId((int)allegiance);
            return ConvertManyToModels(dtos);
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAllJedi()
        {
            IEnumerable<CharacterDTO> dtos = _repository.GetAllJedi();
            return ConvertManyToModels(dtos);
        }

        /// <inheritdoc/>
        public IEnumerable<CharacterModel> GetAllByTrilogy(Trilogy trilogy)
        {
            IEnumerable<CharacterDTO> dtos = _repository.GetAllByTrilogyId((int)trilogy);
            return ConvertManyToModels(dtos);
        }

        /// <inheritdoc/>
        public CharacterModel Add(CharacterModel model)
        {
            CharacterDTO addedDto = _repository.Add(ConvertToDto(model));
            return ConvertToModel(addedDto);
        }

        /// <summary>
        ///     Converts a <see cref="CharacterModel">character model</see> to a <see
        ///     cref="CharacterDTO">character DTO</see>.
        /// </summary>
        /// <param name="model">
        ///     The <see cref="CharacterModel">character model</see> to convert.
        /// </param>
        /// <returns>The converted <see cref="CharacterDTO">character DTO</see>.</returns>
        /// <remarks>
        ///     The <see cref="CharacterModel.Allegiance">allegiance</see> and <see
        ///     cref="CharacterModel.TrilogyIntroducedIn">trilogy</see> <see langword="enum">enum</see>
        ///     values are converted to <see cref="int">integer</see> IDs.
        /// </remarks>
        private CharacterDTO ConvertToDto(CharacterModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new CharacterDTO
            {
                Id = model.Id,
                Name = model.Name,
                AllegianceId = (int)model.Allegiance,
                IsJedi = model.IsJedi,
                TrilogyIntroducedInId = (int)model.TrilogyIntroducedIn,
            };
        }

        /// <summary>
        ///     Converts a <see cref="CharacterDTO">character DTO</see> to a <see
        ///     cref="CharacterModel">character model</see>.
        /// </summary>
        /// <param name="dto">
        ///     The <see cref="CharacterDTO">character DTO</see> to convert.
        /// </param>
        /// <returns>The converted <see cref="CharacterModel">character model</see>.</returns>
        /// <remarks>
        ///     The <see cref="CharacterDTO.AllegianceId">allegiance ID</see> is converted to an <see
        ///     cref="Allegiance">allegiance</see> <see langword="enum">enum</see> and the <see
        ///     cref="CharacterDTO.TrilogyIntroducedInId">trilogy introduced in ID</see> is converted to
        ///     a <see cref="Trilogy">trilogy</see> <see langword="enum">enum</see>.
        /// </remarks>
        private CharacterModel ConvertToModel(CharacterDTO dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new CharacterModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Allegiance = (Allegiance)dto.AllegianceId,
                IsJedi = dto.IsJedi,
                TrilogyIntroducedIn = (Trilogy)dto.TrilogyIntroducedInId,
            };
        }

        /// <summary>
        ///     Converts a <see cref="IEnumerable{CharacterDTO}">collection</see> of <see
        ///     cref="CharacterDTO">character DTO</see>s to a <see
        ///     cref="IEnumerable{CharacterModel}">collection</see> of <see
        ///     cref="CharacterModel">character model</see>s.
        /// </summary>
        /// <param name="characterDTOs">
        ///     The <see cref="IEnumerable{CharacterDTO}">collection</see> of <see
        ///     cref="CharacterDTO">character DTO</see>s to convert.
        /// </param>
        /// <returns>
        ///     The converted <see cref="IEnumerable{CharacterModel}">collection</see> of <see
        ///     cref="CharacterModel">character model</see>s.
        /// </returns>
        private IEnumerable<CharacterModel> ConvertManyToModels(
            IEnumerable<CharacterDTO> characterDTOs
        )
        {
            List<CharacterModel> models = new List<CharacterModel>();
            foreach (CharacterDTO dto in characterDTOs)
            {
                models.Add(ConvertToModel(dto));
            }
            return models;
        }
    }
}
