using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DeepBlue.Entities;
using DeepBlue.Infra.Data.Contracts.Repository;
using DeepBlue.Presentation.Models;
using DeepBlue.Presentation.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepBlue.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        [HttpPost]
        public IActionResult POST([FromBody] ProdutoCadastroModel model, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = mapper.Map<Produto>(model);
                    repository.Create(produto);

                    return Ok("Produto registrado com sucesso.");
                }
                catch (Exception erro)
                {
                    return StatusCode(500, erro.Message);
                }
            }
            else
            {
                return StatusCode(400, ModelStateValidation.GetErrors(ModelState));
            }
        }

        [HttpPut]
        public IActionResult PUT([FromBody] ProdutoEdicaoModel model, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var produto = mapper.Map<Produto>(model);
                    repository.Update(produto);

                    return Ok("Produto atualizado com sucesso.");
                }
                catch (Exception erro)
                {
                    return StatusCode(500, erro.Message);
                }
            }
            else
            {
                return StatusCode(400, ModelStateValidation.GetErrors(ModelState));
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DELETE(Guid id, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                repository.Remove(id);

                return Ok("Produto excluido com sucesso.");
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutoConsultaModel>), 200)]
        public IActionResult GET([FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                return Ok(repository.SelectAll());
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutoConsultaModel), 200)]
        public IActionResult GETById(Guid id, [FromServices] IProdutoRepository repository)
        {
            try
            {
                if (id != null)
                {
                    return Ok(repository.SelectById(id));
                }
                
                return StatusCode(400, "Campo Id é obrigatório.");

            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }
    }
}