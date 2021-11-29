using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Authenticators;
using Trackhive.NET.Requests;
using Trackhive.NET.Responses;
using Trackhive.NET.Types;

namespace Trackhive.NET
{
    public class TrackhiveClient
    {
        private readonly RestClient _client;
        
        public TrackhiveClient(string apiToken, string baseUrl = "https://api.trackinghive.com")
        {
            _client = new RestClient(baseUrl);
            _client.Authenticator = new JwtAuthenticator(apiToken);
        }

        /// <summary>
        /// Gets a list of all couriers that are supported by Trackhive.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Courier>> GetCouriersAsync()
        {
            // TODO: Maybe implement some form of caching as this is unlikely to change often
            var couriersResponse =
                await _client.GetAsync<CourierListResponse>(new RestRequest("couriers/list", Method.GET));
            // TODO: Implement return code checking and maybe retrying if the return code allows it ex. 429
            return couriersResponse.Data;
        }

        /// <summary>
        /// This method is used to create a new tracking.
        /// </summary>
        /// <param name="createTrackingRequest"></param>
        /// <returns></returns>
        public async Task<CreateTrackingResponse> CreateTrackingAsync(CreateTrackingRequest createTrackingRequest)
        {
            var request = new RestRequest("trackings", Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(createTrackingRequest, new JsonSerializerSettings
            {
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Ignore
            }), ParameterType.RequestBody);

            var response = await _client.PostAsync<CreateTrackingResponse>(request);

            return response;
        }

        public async Task<object> GetTrackingDetailsAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is used to get a list of trackings.
        /// </summary>
        /// <param name="pageId">Page number to fetch the details from</param>
        /// <param name="limit">Number of records to fetch per page (Default: 20)</param>
        /// <param name="filters">JSON object for filtering</param>
        /// <param name="searchQuery">Search string to search the tracking list (Search creteria: orderId, TrackingNumber, Customer Name, Customer Email)</param>
        /// <returns></returns>
        public async Task<TrackingListResponse> GetTrackingsAsync(int pageId = 1, int limit = 20, TrackingListFilters? filters = null, string searchQuery = "")
        {
            var request = new RestRequest("trackings", Method.GET);
            request.AddParameter(nameof(pageId), pageId);
            request.AddParameter(nameof(limit), limit);
            if (filters != null) // TODO: Get the filter to work
                request.AddParameter(nameof(filters), JsonConvert.SerializeObject(new { filters }, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Formatting = Formatting.None,
                    NullValueHandling = NullValueHandling.Ignore
                }));
            if (!string.IsNullOrEmpty(searchQuery))
                request.AddParameter(nameof(searchQuery), searchQuery);

            var response = await _client.GetAsync<TrackingListResponse>(request);

            return response;
        }

    }
}