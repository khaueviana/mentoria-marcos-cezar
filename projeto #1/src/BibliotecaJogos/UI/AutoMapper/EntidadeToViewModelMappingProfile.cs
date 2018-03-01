using AutoMapper;
using Entidades;
using UI.Areas.Cadastros.ViewModels;
using UI.Areas.Tabelas.ViewModels;

namespace UI.AutoMapper
{
    public class EntidadeToViewModelMappingProfile : Profile
    {
        public EntidadeToViewModelMappingProfile()
        {

            CreateMap< Genero, GeneroViewModel>();
            CreateMap<Produtora, ProdutoraViewModel>();
            CreateMap<Plataforma, PlataformaViewModel>();
            CreateMap<Jogo, JogoViewModel>();
        }
    }
}