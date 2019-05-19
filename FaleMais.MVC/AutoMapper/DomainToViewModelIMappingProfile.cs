

using AutoMapper;
using FaleMais.Domain.Entites;
using FaleMais.MVC.ViewModels;

namespace FaleMais.MVC.AutoMapper
{
    public class DomainToViewModelIMappingProfile : Profile
    {
        public DomainToViewModelIMappingProfile()
        {
           CreateMap<TarifaViewModel, Tarifa>();
        }
    }
}