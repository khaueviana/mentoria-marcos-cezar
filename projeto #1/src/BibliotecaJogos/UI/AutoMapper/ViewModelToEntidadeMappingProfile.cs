using AutoMapper;
using Entidades;
using UI.Areas.Genero.ViewModels;

namespace UI.AutoMapper
{
    public class ViewModelToEntidadeMappingProfile : Profile
    {
        public ViewModelToEntidadeMappingProfile()
        {
            CreateMap<GeneroViewModel, Genero>();
        }
    }
}