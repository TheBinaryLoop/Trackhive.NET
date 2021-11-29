using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trackhive.NET.Requests
{
    public class CreateTrackingRequest
    {
        /// <summary>
        /// Courier slug name (slug name from courier list API)
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Tracking number
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 2 character ISO language code (ex: en) for couriers: GLS
        /// </summary>
        [JsonProperty("languag_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Any object that consists of key value pair
        /// </summary>
        [JsonProperty("custom_fields")]
        public dynamic? CustomFields { get; set; }

        /// <summary>
        /// Order id associated with the shipment
        /// </summary>
        [JsonProperty("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// Order url of your order associated with shipment
        /// </summary>
        [JsonProperty("order_url")]
        public string? OrderUrl { get; set; }

        /// <summary>
        /// Name of the customer
        /// </summary>
        [JsonProperty("customer_name")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Email ids of the customer to send tracking updates
        /// </summary>
        [JsonProperty("customer_emails")]
        public IList<string>? CustomerEmails { get; set; }

        /// <summary>
        /// Phone numbers of the customer to send tracking updates. It should be in format country code followed by number without any spaces (ex:- +919876456378)
        /// </summary>
        [JsonProperty("customer_phone_numbers")]
        public IList<string>? CustomerPhoneNumbers { get; set; }

        /// <summary>
        /// Origin sorce of the tracking (Default set to api)
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Required by courier like TNT to get accurate tracking information
        /// </summary>
        [JsonProperty("origin_country")]
        public string? OriginCountry { get; set; }

        public CreateTrackingRequest() {}

        public CreateTrackingRequest(string slug, string trackingNumber)
        {
            Slug = slug;
            TrackingNumber = trackingNumber;
        }
    }
}
