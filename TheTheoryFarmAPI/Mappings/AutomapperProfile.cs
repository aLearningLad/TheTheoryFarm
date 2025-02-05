using AutoMapper;
using TheTheoryFarmAPI.Models.Domain;
using TheTheoryFarmAPI.Models.DTOs;

namespace TheTheoryFarmAPI.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Theory, TheoryDto>().ReverseMap();
            CreateMap<Theory, AddTheoryRequestDto>().ReverseMap();
        }
    }
}
