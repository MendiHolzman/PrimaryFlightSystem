using Microsoft.AspNetCore.Mvc;
using PrimaryFlightSystem.Shared;
using Services;
using Services.DataDB;

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
            if (res == null)
            {
                return new ResultData(res.Id = -1);
            }
            return new ResultData(res);
        }
    }
}
