using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimaryFlightSystem.Shared;
using Services;
using System;
using System.Collections.Generic;

namespace PrimaryFlightSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class InitController : MyBaceController
    {

        private IFlightsService flightsService;
        private IInitService initService;
        public InitController(IInitService initService, IFlightsService flightsService)
        {
            this.initService = initService;
            this.flightsService = flightsService;
        }

        public ResultData CreateRoutes()
        {
            var res = initService.CreateRoutes();
            return new ResultData(res);
        } 
        
        public ResultData UpdateCurrentFlightsPerLeg()
        {
            flightsService.UpdateCurrentFlightsPerLeg();
            return new ResultData(true);
        }

    }
}
