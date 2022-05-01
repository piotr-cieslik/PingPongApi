using Microsoft.AspNetCore.Mvc;

namespace PingPongApi.Controllers
{
    [ApiController]
    public class PingPongController : ControllerBase
    {
        [HttpGet()]
        [Route("ping")]
        [Produces("text/plain")]
        public string Ping()
        {
            return "pong";
        }

        [HttpGet()]
        [Route("pong")]
        [Produces("text/plain")]
        public string Pong()
        {
            return "ping";
        }
    }
}