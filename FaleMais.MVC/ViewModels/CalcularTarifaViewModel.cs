using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaleMais.MVC.ViewModels
{
    public class CalcularTarifaViewModel
    {
        public int Origem { get; set; }
        public int Destino { get; set; }
        public int Tempo { get; set; }
        public string  Plano { get; set; }
        public double CalculoComPlano { get; set; }
        public double CalculoSemPlano { get; set; }

    }
}