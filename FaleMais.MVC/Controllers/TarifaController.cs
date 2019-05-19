using AutoMapper;
using FaleMais.Domain.Entites;
using FaleMais.infra.Date2.Repositories;
using FaleMais.MVC.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FaleMais.MVC.Controllers
{
    public class TarifaController : Controller
    {
        private readonly TarifaRepository _TarifaRepository = new TarifaRepository();
        private readonly PlanoRepository _PlanoRepository = new PlanoRepository();
        // GET: Tarifa
        public ActionResult Index()
        {
            var tarifa = Mapper.Map<IEnumerable<Tarifa>, IEnumerable<TarifaViewModel>>(_TarifaRepository.GetAll());

            ViewBag.Plano = Mapper.Map<IEnumerable<Plano>, IEnumerable<PlanoViewModel>>(_PlanoRepository.GetAll());

            return View(tarifa);
        }

        public JsonResult GetDestino(int dddOrigem)
        {
            var tarifa = Mapper.Map<IEnumerable<Tarifa>, IEnumerable<TarifaViewModel>>(_TarifaRepository.GetAll());
            var tarifaFiltro = tarifa.Where(x => x.Origem == dddOrigem);
            var destino  = tarifaFiltro.Select(x => x.Destino);
            return Json(destino, JsonRequestBehavior.AllowGet);
        }       

    }
}