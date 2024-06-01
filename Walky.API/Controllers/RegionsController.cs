using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Walky.API.Data;
using Walky.API.Models.Domain;
using Walky.API.Models.DTO;
using Walky.API.Repositories.IRepository;

namespace Walky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly WalkyDbContext _dbContext;
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(WalkyDbContext dbContext,IRegionRepository regionRepository,IMapper mapper)
        {
            _dbContext = dbContext;
            _regionRepository = regionRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await _regionRepository.GetAllAsync();

            return Ok(_mapper.Map<List<RegionDto>>(regions));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var region = await _regionRepository.GetByIdAsync(id);

            if(region == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<RegionDto>(region));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRegionDto createRegionDto)
        {
            var region = await _regionRepository.CreateAsync(_mapper.Map<Region>(createRegionDto));
            var regionDto = _mapper.Map<RegionDto>(region);

            return CreatedAtAction(nameof(GetById),new { id = regionDto.Id},regionDto);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionDto updateRegionDto)
        {
            var region = _mapper.Map<Region>(updateRegionDto);
            region = await _regionRepository.UpdateAsync(id, region);

            if(region == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<RegionDto>(region));
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _regionRepository.DeleteAsync(id);

            if(!result)
            {
                return NotFound();
            }

            return Ok();

        }
    }
}
