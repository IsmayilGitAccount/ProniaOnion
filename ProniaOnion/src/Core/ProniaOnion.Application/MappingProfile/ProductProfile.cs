using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProniaOnion.Application.DTOs.Products;
using ProniaOnion.Domain.Entities;

namespace ProniaOnion.Application.MappingProfile
{
    internal class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductItemDTO>().ReverseMap();
        }
    }
}
