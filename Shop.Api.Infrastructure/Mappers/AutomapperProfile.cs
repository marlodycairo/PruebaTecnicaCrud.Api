﻿using AutoMapper;
using PruebaTecnicaCrud.Api.Core.DTOs.Authors;
using PruebaTecnicaCrud.Api.Core.Entities;

namespace Shop.Api.Infrastructure.Mappers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Author, CreateAuthor>();
            CreateMap<CreateAuthor, Author>();

            CreateMap<Author, AuthorResponse>();
            CreateMap<AuthorResponse, Author>();

            CreateMap<Author, UpdateAuthor>();
            CreateMap<UpdateAuthor, Author>();
        }
    }
}
