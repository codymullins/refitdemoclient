using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ClassLibraryDemo
{
    public interface IDemoClient
    {
        [Get("")]
        Task<HttpResponseMessage> Get();
    }
}
