using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trackhive.NET.Types
{
    public class Tracking
    {
        /// <summary>
        /// Unique id to identify the tracking
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Courier slug name (slug name from courier list API)
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Tracking number
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Origin sorce of the tracking (Default set to api)
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Tracking details of the tracking
        /// </summary>
        public TrackingTrackings Trackings { get; set; }

        /// <summary>
        /// Current status of the tracking 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TrackingStatus CurrentStatus { get; set; }

        /// <summary>
        /// Any object that consists of key value pair
        /// </summary>
        public dynamic? CustomFields { get; set; }

        /// <summary>
        /// Order id associated with the shipment
        /// </summary>
        public string? OrderId { get; set; }

        /// <summary>
        /// Order url of your order associated with shipment
        /// </summary>
        public string? OrderUrl { get; set; }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// Email ids of the customer to send tracking updates
        /// </summary>
        public IList<string>? CustomerEmails { get; set; }

        /// <summary>
        /// Phone numbers of the customer to send tracking updates. It should be in format country code followed by number without any spaces (ex:- +919876456378)
        /// </summary>
        public IList<string>? CustomerPhoneNumbers { get; set; }

        /// <summary>
        /// True or False value based on whether the shipment will return to sender or not
        /// </summary>
        public bool ReturnToSender { get; set; } = false;

        /// <summary>
        /// Tracking created date in UTC timezone
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Tracking modified date in UTC timezone
        /// </summary>
        public DateTime Modified { get; set; }
    }
}
