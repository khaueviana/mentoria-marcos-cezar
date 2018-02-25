﻿using AutoMapper;
using Entidades;
using UI.Areas.Genero.ViewModels;
using UI.Areas.Produtora.ViewModels;

namespace UI.AutoMapper
{
    public class ViewModelToEntidadeMappingProfile : Profile
    {
        public ViewModelToEntidadeMappingProfile()
        {
            CreateMap<GeneroViewModel, Genero>();
            CreateMap<ProdutoraViewModel, Produtora>();
        }
    }
}