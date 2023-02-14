using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using example_bi_directional_consumer_dotnet.core.src.Models;

namespace example_bi_directional_consumer_dotnet.core.src
{
    public interface IMyApiClient
    {
        Task<MyActionResult> PostAsync(string urlSufix, object postData, bool returnContent = false);

        Task<MyActionResult> PostAsync<T>(string urlSufix, object postData, bool shouldIncludeHeaders = false);
    }
}
