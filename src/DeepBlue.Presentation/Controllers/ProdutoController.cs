using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeepBlue.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        [HttpPost]
        public IActionResult POST([FromBody] ProdutoCadastroModel model)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PUT([FromBody] ProdutoEdicaoModel model)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DELETE(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutoConsultaModel>), 200)]
        public IActionResult GET()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutoConsultaModel), 200)]
        public IActionResult GETById(Guid id)
        {
            return Ok();
        }
    }
}