using AutoMapper;
using Entidades;
using UI.Areas.Genero.ViewModels;

namespace UI.AutoMapper
{
    public class EntidadeToViewModelMappingProfile : Profile
    {
        public EntidadeToViewModelMappingProfile()
        {

            CreateMap< Genero, GeneroViewModel>();
        }
    }
}