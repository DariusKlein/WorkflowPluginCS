using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Flurl.Http;

namespace WorkflowPlugin.services
{
    public class Api
    {
        public static async Task<string> Debug(object data)
        {
            var responseString = await "https://workflow.kleinwizard.nl/debug"
                .WithBasicAuth("darius", ">>QPSOnn" )
                .PostJsonAsync(new { data})
                .ReceiveString();

            return responseString;
        }
        
        public static async Task<string> Events(object jsonData)
        {
            var responseString = await "https://workflow.kleinwizard.nl/api/events"
                .WithBasicAuth("darius", ">>QPSOnn" )
                .PostJsonAsync(jsonData)
                .ReceiveString();

            return responseString;
        }
        
        public static async Task<string> CreateCheckIn(object jsonData)
        {
            var responseString = await "https://workflow.kleinwizard.nl/checkIn/create"
                .WithBasicAuth("darius", ">>QPSOnn" )
                .PostJsonAsync(jsonData)
                .ReceiveString();

            return responseString;
        }
    }
}
