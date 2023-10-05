using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace BTKAkademiWeb.MVC.Infrastructe.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForInsertion, Product>();
        }
    }
}