using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWalkDto createWalkDto)
        {
            var walkCreateDto = _mapper.Map<Walk>(createWalkDto);
            var walk = await _walkRepository.CreateAsync(walkCreateDto);

            return Ok(_mapper.Map<WalkDto>(walk));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var walksDomain = await _walkRepository.GetAllAsync();

           return Ok(_mapper.Map<List<WalkDto>>(walksDomain)); 
        }
    }
}
