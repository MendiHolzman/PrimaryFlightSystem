using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DataDB;
using PrimaryFlightSystem.Shared;

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

        public ResultData GetRoute(string routeNumber)
        {
            var res = flightsSer.GetRoute(routeNumber);

            return new ResultData(res) { Status = true };
        }

        public ResultData GetAllFlights()
        {
            var res = flightsSer.GetAllFlights();
            return new ResultData("") { Status = res };
        }

        public ResultData FillFlights()
        {
            var res = flightsSer.FillFlights();
            return new ResultData("") { Status = res };
        }

        public ResultData DeleteFlights()
        {
            var res = flightsSer.DeleteFlights();
            return new ResultData("") { Status = res };
        }

        public ResultData MoveFlights()
        {
            flightsSer.MoveFlights();
            return new ResultData("") { Status = true };
        }




    }
}
