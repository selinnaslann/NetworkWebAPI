using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NetworkWebAPI.WebAPI.Entities;
using NetworkWebAPI.WebAPI.Entities.ViewModels;

namespace NetworkWebAPI.WebAPI.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, GetProductViewModel>().ForMember(dest => dest.Category,
                opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<PostProductQueryViewModel, Product>();
        }
    }
}
