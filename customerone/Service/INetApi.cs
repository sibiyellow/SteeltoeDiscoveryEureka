using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace customerone.Service
{
    [HttpHost("http://serviceone")]
    public interface INetApi: IHttpApi
    {
        [HttpGet("api/values")]
        ITask<string[]> GetValuesAsync();
    }
}
