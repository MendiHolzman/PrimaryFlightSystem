namespace PrimaryFlightSystem.Controllers
{
    public partial class LegsController
    {
        public class ResultData
        {
            public ResultData(object res)
            {
                Data = res;
            }
            public object Data { get; set; }
            public object Status { get; set; }
        }

    }
}
