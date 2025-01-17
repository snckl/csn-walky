﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Walky.API.CustomActionFilters;
using Walky.API.Models.Domain;
using Walky.API.Models.DTO;
using Walky.API.Repositories.IRepository;

namespace Walky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IWalkRepository _walkRepository;

        public WalksController(IMapper mapper,IWalkRepository walkRepository)
        {
            _mapper = mapper;
            _walkRepository = walkRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, 
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            var walksDomain = await _walkRepository.GetAllAsync(filterOn,filterQuery,sortBy,pageNumber,pageSize);

            return Ok(_mapper.Map<List<WalkDto>>(walksDomain));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walk = await _walkRepository.GetByIdAsync(id);

            if (walk == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] CreateWalkDto createWalkDto)
        {
                var walkCreateDto = _mapper.Map<Walk>(createWalkDto);
                var walk = await _walkRepository.CreateAsync(walkCreateDto);

                return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWalkDto updateWalkDto)
        {
            var walk = _mapper.Map<Walk>(updateWalkDto);
            walk = await _walkRepository.UpdateAsync(id,walk);

            if(walk == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
          var result = await _walkRepository.RemoveAsync(id);

          if (result)
          {
              return NotFound();
          }

          return NoContent();
        }

    }
}
