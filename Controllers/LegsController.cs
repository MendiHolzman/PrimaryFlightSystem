using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DataDB;
using System.Collections.Generic;
using System.Linq;

namespace PrimaryFlightSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public partial class LegsController : MyBaceController
    {
        private ILegsService legsSer;
        public LegsController(ILegsService legsSer)
        {
            this.legsSer = legsSer;
        }

        public ResultData GetLegFlights(int legNumber)
        {
            var res = legsSer.GetLegFlights(legNumber);
            return new ResultData(res);
        }

        public ResultData GetLegDetailsById(int id)
        {
            var res = legsSer.GetLegDetailsById(id);
            return new ResultData(res);
        }
    }
}
