using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace customerclient
{
    public interface IEurekaClientService
    {
        Task<string> GetTestAsync(string action);
    }
}
