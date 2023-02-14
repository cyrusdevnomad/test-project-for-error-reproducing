using example_bi_directional_consumer_dotnet.core.src.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace example_bi_directional_consumer_dotnet.core.src
{
    public class EmailApiClient: IEmailApiClient
    {
        private readonly IMyApiClient _apiProvider;

        public EmailApiClient(IMyApiClient apiProvider)
            => _apiProvider = apiProvider;

        public async Task<MyActionResult> SendMail(MyEmailMessage message)
        {
            try
            {
                return await _apiProvider.PostAsync<object>("v1/Mail", message);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}

