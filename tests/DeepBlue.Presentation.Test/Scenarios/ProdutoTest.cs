using DeepBlue.Presentation.Models;
using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeepBlue.Presentation.Test.Scenarios
{
    
    public class ProdutoTest
    {
        private readonly TestContext testContext;

        private readonly string endPoint;
                
        public ProdutoTest()
        {
            testContext = new TestContext();
            endPoint = "/api/produto";
        }

        [Fact]
        public async Task Produto_Post_ReturnsOkResponse()
        {
            var model = new ProdutoCadastroModel
            {
                Nome = "Produto Teste",
                Preco = 100m,
                Quantidade = 10
            };

            var request = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await testContext.Client.PostAsync(endPoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Produto_Post_Returns400Response()
        {
            var model = new ProdutoCadastroModel
            {
                Nome = null,
                Preco = 100m,
                Quantidade = 10
            };

            var request = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await testContext.Client.PostAsync(endPoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Produto_Put_ReturnsOkResponse()
        {
            
            var model = new ProdutoEdicaoModel
            {
                Id = Guid.NewGuid(),
                Nome = "Produto Teste",
                Preco = 100m,
                Quantidade = 10
            };


            var request = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await testContext.Client.PutAsync(endPoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Produto_Delete_ReturnsOkResponse()
        {
            var Id = Guid.NewGuid();

            var response = await testContext.Client.DeleteAsync($"{endPoint}/{Id}");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Produto_GET_ReturnsOkResponse()
        {
            var response = await testContext.Client.GetAsync(endPoint);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Produto_GETById_ReturnsOkResponse()
        {
            var Id = Guid.NewGuid();

            var response = await testContext.Client.GetAsync(endPoint);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
