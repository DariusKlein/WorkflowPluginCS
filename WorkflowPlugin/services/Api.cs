using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Flurl.Http;

namespace WorkflowPlugin.services
{
    public class Api
    {
        public static async Task<string> PostData(string data)
        {
            var responseString = await "https://workflow.kleinwizard.nl/debug"
                .WithBasicAuth("darius", ">>QPSOnn" )
                .PostJsonAsync(new { data})
                .ReceiveString();

            return responseString;
        }
    }
}
