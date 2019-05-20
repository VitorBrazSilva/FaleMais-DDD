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
        private readonly TarifaRepository _tarifaRepository = new TarifaRepository();
        private readonly PlanoRepository _planoRepository = new PlanoRepository();
        // GET: Tarifa
        public ActionResult Index()
        {
            var tarifa = Mapper.Map<IEnumerable<Tarifa>, IEnumerable<TarifaViewModel>>(_tarifaRepository.GetAll());

            ViewBag.Plano = Mapper.Map<IEnumerable<Plano>, IEnumerable<PlanoViewModel>>(_planoRepository.GetAll());

            return View(tarifa);
        }

        public JsonResult GetDestino(int dddOrigem)
        {
            int[] destinos = _tarifaRepository.ObterDestinos(dddOrigem).ToArray();

            if (destinos.Count() == 0)
                return Json("Nenhum destino encontrado com a origem selecionada!", JsonRequestBehavior.AllowGet);

            return Json(destinos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Calcular(int origem, int destino, int tempoPlano, int tempoGasto)
        {

            double valorComPlano = _planoRepository.CalcularValorComPlano(origem, destino, tempoPlano, tempoGasto);
            double valorSemPlano = _planoRepository.CalcularValorSemPlano(origem, destino, tempoGasto);


            CalcularTarifaViewModel t = new CalcularTarifaViewModel()
            {
                Origem = origem,
                Destino = destino,
                Plano = "Fale Mais" + tempoPlano,
                Tempo = tempoGasto,
                CalculoComPlano = valorComPlano,
                CalculoSemPlano = valorSemPlano
            };


            return Json(t, JsonRequestBehavior.AllowGet);
        }

    }
}