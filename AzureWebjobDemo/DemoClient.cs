using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace RefitDemoClient
{
    public interface IDemoClient
    {
        [Get("/demo")]
        Task<HttpResponseMessage> Get();
    }
}
