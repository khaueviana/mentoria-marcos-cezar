using AutoMapper;
using Entidades;
using UI.Areas.Cadastros.ViewModels;
using UI.Areas.Tabelas.ViewModels;

namespace UI.AutoMapper
{
    public class ViewModelToEntidadeMappingProfile : Profile
    {
        public ViewModelToEntidadeMappingProfile()
        {
            CreateMap<GeneroViewModel, Genero>();
            CreateMap<ProdutoraViewModel, Produtora>();
            CreateMap<PlataformaViewModel, Plataforma>();
            CreateMap<JogoViewModel, Jogo>();
        }
    }
}