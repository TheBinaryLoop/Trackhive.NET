using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;
using RestSharp;
using Trackhive.NET.Extensions;
using Trackhive.NET.Responses;
using Trackhive.NET.Types;

namespace Trackhive.NET
{
    public class TrackhiveClient
    {
        private readonly SecureString _apiToken;
        private readonly RestClient _client;
        
        public TrackhiveClient(string apiToken, string baseUrl = "https://api.trackinghive.com")
        {
            _apiToken = apiToken.ToSecureString();
            _client = new RestClient(baseUrl);
        }

        /// <summary>
        /// Gets a list of all couriers that are supported by Trackhive.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Courier>> GetCouriersAsync()
        {
            // TODO: Maybe implement some form of caching as this is unlikely to change often
            var couriersResponse =
                await _client.GetAsync<BaseResponse<List<Courier>>>(new RestRequest("couriers/list", Method.GET));
            // TODO: Implement return code checking and maybe retrying if the return code allows it ex. 429
            return couriersResponse.Data;
        }

    }
}