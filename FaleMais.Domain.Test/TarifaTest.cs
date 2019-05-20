using FaleMais.infra.Date2.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FaleMais.Domain.Test
{
    public class TarifaTest
    {
        private readonly TarifaRepository _tarifaRepository = new TarifaRepository();
        private readonly PlanoRepository _planoRepository = new PlanoRepository();

        [Fact]
        public void CalcularTarifaComPlanoTest()
        {
            int origem = 11;
            int destino = 16;
            int tempoPlano = 30;
            int tempoGasto = 30;

            double valorComPlano = _planoRepository.CalcularValorComPlano(origem, destino, tempoPlano, tempoGasto);
            Assert.Equal(0, valorComPlano);
        }
    }
}
