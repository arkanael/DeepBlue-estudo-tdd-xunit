using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace DeepBlue.Presentation.Test
{
    public class TestContext
    {
        private TestServer server;

        public HttpClient Client{ get; set; }

        public TestContext()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Presentation.Startup>());

            Client = server.CreateClient();
        }

    }
}
