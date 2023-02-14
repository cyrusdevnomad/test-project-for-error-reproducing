using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace example_bi_directional_consumer_dotnet.core.src.Models
{
    [ExcludeFromCodeCoverage]
    public class MyActionResult
    {
        public bool IsSuccessful => Status == MyActionStatus.Ok;

        public MyActionStatus Status { get; set; }

        public object Content { get; set; }

        public MyActionResult(MyActionStatus status, object content = null)
        {
            Status = status;
            Content = content;
        }

        public static MyActionResult Success() => new(MyActionStatus.Ok);

        public static MyActionResult Success(object content) => new(MyActionStatus.Ok, content);
    }
}