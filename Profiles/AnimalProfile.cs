using AutoMapper;
using WoofHub_App.Data.DTOs;
using WoofHub_App.Models;

namespace WoofHub_App.Profiles
{
    public class AnimalProfile : Profile
    {
        public AnimalProfile()
        {
            CreateMap<AnimalDTO, AnimalModel>();
        }
    }
}