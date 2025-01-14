﻿using HotelJuanApp.Application.AppService;
using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HotelJuanApp.Tests.Application
{
    public class ReservaUnitest
    {
        [Fact]
        public void Test1()
        {
            ConsultaPeriodoViewModel consulta = new ConsultaPeriodoViewModel(
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(6),
                2
            );

            IReservaAppService reservaApp = new ReservaAppService();
            var x = reservaApp.GetQuartosDisponiveis(consulta);

            Assert.True(x.Count > 0);
        }
    }
}
