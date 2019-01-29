using Microsoft.Extensions.Logging;
using Steeltoe.Common.Discovery;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace customerclient
{
    public class EurekaClientService: IEurekaClientService
    {
        DiscoveryHttpClientHandler _handler;

        private const string GET_SERVICES_URL = "http://localhost:8888/";
        private ILogger<EurekaClientService> _logger;

        public EurekaClientService(IDiscoveryClient client, ILoggerFactory logFactory = null)
        {
            _handler = new DiscoveryHttpClientHandler(client, logFactory?.CreateLogger<DiscoveryHttpClientHandler>());
            _logger = logFactory?.CreateLogger<EurekaClientService>();
        }

        public async Task<string> GetTestAsync(string action)
        {
            _logger?.LogInformation("GetServices");
            var client = GetClient();
            return await client.GetStringAsync(GET_SERVICES_URL+ action);

        }

        private HttpClient GetClient()
        {
            var client = new HttpClient(_handler, false);
            return client;
        }
    }
}
