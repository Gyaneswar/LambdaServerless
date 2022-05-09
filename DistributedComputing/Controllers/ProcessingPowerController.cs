using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedComputing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessingPowerController : ControllerBase
    {
        [HttpGet]
        public JsonResult Power(int a, int b)
        {
            return new JsonResult(a + b);
        }
    }
}
