using Microsoft.Extensions.DependencyInjection;
using System;
using WebApiClient;

namespace customerclient
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            //注入
            services.AddSingleton<IEurekaClientService, EurekaClientService>();

            //构建容器
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            //解析
            var client = serviceProvider.GetService<IEurekaClientService>();
            
            var result = client.GetTestAsync("api/values");
            Console.WriteLine(result.GetAwaiter().GetResult());
            Console.ReadLine();
        }
    }
}
