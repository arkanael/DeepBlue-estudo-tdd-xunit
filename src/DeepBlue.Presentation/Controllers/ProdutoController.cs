using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
       [HttpPost]
       public IActionResult POST()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PUT()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DELETE()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GET()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GETALL()
        {
            return Ok();
        }
    }
}
