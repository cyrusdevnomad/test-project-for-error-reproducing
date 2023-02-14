using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace example_bi_directional_consumer_dotnet.core.src.Models
{
    [ExcludeFromCodeCoverage]
    public class MyEmailRecipient
    {
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        public MyEmailRecipient(string firstName, string lastName, string emailAddress) =>
            (FirstName, LastName, EmailAddress) = (firstName, lastName, emailAddress);
    }
}

