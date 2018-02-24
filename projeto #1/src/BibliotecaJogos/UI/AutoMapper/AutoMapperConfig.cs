using AutoMapper;

namespace UI.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistarMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntidadeToViewModelMappingProfile>();
                x.AddProfile<ViewModelToEntidadeMappingProfile>();
            });
        }
    }
}