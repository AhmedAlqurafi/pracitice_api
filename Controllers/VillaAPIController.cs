using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_MagicVilla.Data;
using Practice_MagicVilla.Models;
using Practice_MagicVilla.Models.Dto;
using Practice_MagicVilla.Repository.IRepository;

namespace Practice_MagicVilla.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        public readonly ILogger<VillaAPIController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IVillaRepository _dbVilla;
        protected APIResponse _response;

        public VillaAPIController(ILogger<VillaAPIController> logger, ApplicationDbContext db, IMapper mapper, IVillaRepository dbVilla)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
            _dbVilla = dbVilla;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            try
            {
                _logger.LogInformation("Getting all villas");
                IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        // [HttpGet("{id}")]
        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaById(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var villa = await _dbVilla.GetAsync(villa => villa.Id == id);

                if (villa == null)
                {
                    return NotFound();
                }

                _response.Result = _mapper.Map<VillaDTO>(villa);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            try
            {
                // if (!ModelState.IsValid)
                // {
                //     return BadRequest(ModelState);
                // }

                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

                Villa newVilla = _mapper.Map<Villa>(createDTO);
                // Villa newVilla = new()
                // {
                //     Amenity = createDTO.Amenity,
                //     Details = createDTO.Details,
                //     ImageUrl = createDTO.ImageUrl,
                //     Name = createDTO.Name,
                //     Occupancy = createDTO.Occupancy,
                //     Rate = createDTO.Rate,
                //     Sqft = createDTO.Sqft,
                //     CreatedDate = DateTime.Now
                // };

                await _dbVilla.CreateAsync(newVilla);

                _response.Result = _mapper.Map<List<VillaDTO>>(newVilla);
                _response.StatusCode = HttpStatusCode.Created;
                _response.IsSuccess = true;
                return CreatedAtRoute("GetVilla", new { id = newVilla.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // public async Task<IActionResult> DeleteVilla(int id)
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var villa = await _dbVilla.GetAsync(villa => villa.Id == id);

                if (villa == null)
                {
                    return NotFound();
                }

                _dbVilla.RemoveAsync(villa);
                _response.Result = _mapper.Map<VillaDTO>(villa);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDTO)
        {
            try
            {
                if (villaDTO == null || id != villaDTO.Id)
                {
                    return BadRequest();
                }

                // if (id == 0)
                // {
                //     return BadRequest();
                // }

                // var villa = await _dbVilla.GetAsync(villa => villa.Id == id, false);

                // villa.Name = villaDTO.Name;
                // villa.Occupancy = villaDTO.Occupancy;
                // villa.Sqft = villaDTO.Sqft;
                // villa.UpdateDate = DateTime.Now;

                Villa newVilla = _mapper.Map<Villa>(villaDTO);
                // Villa newVilla = new()
                // {
                //     Amenity = villaDTO.Amenity,
                //     Details = villaDTO.Details,
                //     Id = villaDTO.Id,
                //     ImageUrl = villaDTO.ImageUrl,
                //     Name = villaDTO.Name,
                //     Occupancy = villaDTO.Occupancy,
                //     Rate = villaDTO.Rate,
                //     Sqft = villaDTO.Sqft,
                //     UpdateDate = DateTime.Now
                // };

                // _db.Villas.Update(newVilla);
                // await _db.SaveChangesAsync();
                await _dbVilla.UpdateAsync(newVilla);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (id == 0 || patchDTO == null)
            {
                return BadRequest();
            }

            var villa = await _dbVilla.GetAsync(villa => villa.Id == id, false);

            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);
            // VillaUpdateDTO villaDTO = new()
            // {
            //     Amenity = villa.Amenity,
            //     Details = villa.Details,
            //     Id = villa.Id,
            //     ImageUrl = villa.ImageUrl,
            //     Name = villa.Name,
            //     Occupancy = villa.Occupancy,
            //     Rate = villa.Rate,
            //     Sqft = villa.Sqft,
            // };
            if (villa == null)
            {
                return NotFound();
            }

            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa newVilla = _mapper.Map<Villa>(villaDTO);
            // Villa newVilla = new()
            // {
            //     Amenity = villaDTO.Amenity,
            //     Details = villaDTO.Details,
            //     Id = villaDTO.Id,
            //     ImageUrl = villaDTO.ImageUrl,
            //     Name = villaDTO.Name,
            //     Occupancy = villaDTO.Occupancy,
            //     Rate = villaDTO.Rate,
            //     Sqft = villaDTO.Sqft,
            //     UpdateDate = DateTime.Now
            // };

            // _db.Villas.Update(newVilla);
            // await _db.SaveChangesAsync();

            await _dbVilla.UpdateAsync(newVilla);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return NoContent();

        }

    }
}