using System;
using System.Collections.Generic;
using System.Text;

namespace example_bi_directional_consumer_dotnet.core.src.Models
{
    public enum MyActionStatus
    {
        Ok = 1,
        Error = -1,
        Duplicate = -2,
        NotFound = -3
    }
}



