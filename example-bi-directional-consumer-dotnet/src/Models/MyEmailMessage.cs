using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace example_bi_directional_consumer_dotnet.core.src.Models
{
    [ExcludeFromCodeCoverage]
    public class MyEmailMessage
    {
        [JsonProperty(PropertyName = "recipients")]
        public List<MyEmailRecipient> Recipients { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        public MyEmailMessage(List<MyEmailRecipient> recipients, string subject, string content) =>
            (Recipients, Subject, Content) = (recipients, subject, content);
    }
}

