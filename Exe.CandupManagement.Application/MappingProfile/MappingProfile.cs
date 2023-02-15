using AutoMapper;
using Exe.CandupManagement.Application.DTOs.Category;
using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Product mappings
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            #endregion

            #region Category mappings
            CreateMap<Category, CategoryDto>().ReverseMap();
            #endregion
        }
    }
}
