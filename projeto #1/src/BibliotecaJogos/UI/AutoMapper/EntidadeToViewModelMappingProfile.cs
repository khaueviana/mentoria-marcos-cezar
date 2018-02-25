using AutoMapper;
using Entidades;
using UI.Areas.Genero.ViewModels;
using UI.Areas.Produtora.ViewModels;

namespace UI.AutoMapper
{
    public class EntidadeToViewModelMappingProfile : Profile
    {
        public EntidadeToViewModelMappingProfile()
        {

            CreateMap< Genero, GeneroViewModel>();
            CreateMap<Produtora, ProdutoraViewModel>();
        }
    }
}