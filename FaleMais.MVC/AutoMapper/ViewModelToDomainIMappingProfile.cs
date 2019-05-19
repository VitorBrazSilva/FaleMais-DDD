
using AutoMapper;
using FaleMais.Domain.Entites;
using FaleMais.MVC.ViewModels;

namespace FaleMais.MVC.AutoMapper
{
    public class ViewModelToDomainIMappingProfile : Profile
    {
        public ViewModelToDomainIMappingProfile()
        {
           CreateMap<TarifaViewModel, Tarifa>();
            
        }
    
    }
}