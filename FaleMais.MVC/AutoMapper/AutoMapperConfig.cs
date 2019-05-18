using AutoMapper;

namespace FaleMais.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new DomainToViewModelIMappingProfile());
                x.AddProfile(new ViewModelToDomainIMappingProfile());

            });
        }
    }
}