using example_bi_directional_consumer_dotnet.core.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_bi_directional_consumer_dotnet.core.src
{
    public interface IEmailApiClient
    {
        Task<MyActionResult> SendMail(MyEmailMessage message);
    }
}
