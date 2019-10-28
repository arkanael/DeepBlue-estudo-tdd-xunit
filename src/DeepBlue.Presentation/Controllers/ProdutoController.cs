using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DeepBlue.Infra.Data.Contracts.Repository;
using DeepBlue.Infra.Data.Entities;
using DeepBlue.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        [HttpPost]
        public IActionResult POST([FromBody] ProdutoCadastroModel model, 
            [FromServices] IProdutoRepository repository,
            [FromServices] IMapper mapper)
        {

            var produto = mapper.Map<Produto>(model);
            repository.Create(produto);

            return Ok();
        }

        [HttpPut]
        public IActionResult PUT([FromBody] ProdutoEdicaoModel model,
             [FromServices] IProdutoRepository repository,
            [FromServices] IMapper mapper)
        {
            var produto = mapper.Map<Produto>(model);

            repository.Update(produto);

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