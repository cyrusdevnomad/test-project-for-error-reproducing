using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace example_bi_directional_consumer_dotnet.core.src
{
    public class FakeClientCredentialsBearerTokenHandler : DelegatingHandler
    {
        public FakeClientCredentialsBearerTokenHandler()
        {
            InnerHandler = new HttpClientHandler();
        }
    }

}
