using AutoMapper;
using Walky.API.Models.Domain;
using Walky.API.Models.DTO;

namespace Walky.API.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Region,RegionDto>().ReverseMap();
            CreateMap<UpdateRegionDto, Region>().ReverseMap();
            CreateMap<CreateRegionDto, Region>().ReverseMap();
            CreateMap<CreateWalkDto,Walk>().ReverseMap();
            CreateMap<Walk,WalkDto>().ReverseMap();

        }
    }
}
