using AutoMapper;
using FaleMais.Domain.Entites;
using FaleMais.infra.Date2.Repositories;
using FaleMais.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace FaleMais.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly TarifaRepository _TarifaRepository = new TarifaRepository();
        public ActionResult Index()
        {
           var tarifa = Mapper.Map<IEnumerable<Tarifa>, IEnumerable<TarifaViewModel>>(_TarifaRepository.GetAll());
            //ViewBag.Origem = tarifa.Select(x => x.Origem).Distinct();
                        
            return View(tarifa);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}