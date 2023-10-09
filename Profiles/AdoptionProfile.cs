using AutoMapper;
using WoofHub_App.Data.Dtos.AdoptionDto;
using WoofHub_App.Models;

namespace WoofHub_App.Profiles
{
    public class AdoptionProfile : Profile
    {
        public AdoptionProfile()
        {
            CreateMap<CreateAdoptionDto, AdoptionModel>();
            CreateMap<AdoptionModel, ReadAdoptionDto>();
            CreateMap<UpdateAdoptionDto, AdoptionModel>();
            CreateMap<AdoptionModel, ReadAdoptionDto>()
                .ForMember(adoptionDto => adoptionDto.AnimalId,
                    opt => opt.MapFrom(adoption => adoption.AnimalId))
                .ForMember(adoptionDto => adoptionDto.ClientId,
                    opt => opt.MapFrom(adoption => adoption.ClientId));
        }
    }
}