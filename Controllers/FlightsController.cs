using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DataDB;
using System.Collections.Generic;
using System.Linq;

namespace PrimaryFlightSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class FlightsController : MyBaceController
    {
        private IFlightsService flightsSer;
        public FlightsController(IFlightsService flightsSer)
        {
            this.flightsSer = flightsSer;
        }

        public ResultData GetFlightPassengers(string flightNumber)
        {
            var res = flightsSer.GetFlightPassengers(flightNumber);
            return new ResultData(res);
        }

        public ResultData GetFlightDetails(string flightNumber)
        {
            var res = flightsSer.GetFlightDetails(flightNumber);
            if (res == null)
            {
                return new ResultData(res.Id = -1);
            }
            return new ResultData(res);
        }
    }
}
