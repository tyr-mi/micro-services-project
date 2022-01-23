using AutoMapper;
using platformservice.Dtos;
using platformservice.Models;

namespace platformservice.Profiles
{
    public class PlatformsProfile : Profile
    {

        public PlatformsProfile()
        {
            //Source to target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatfromCreateDto, Platform>();
        }

    }
}
