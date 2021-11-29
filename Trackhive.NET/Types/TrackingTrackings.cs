using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trackhive.NET.Types
{
    public class TrackingTrackings
    {
        /// <summary>
        /// Signed by information for delivered shipment (if any)
        /// </summary>
        public dynamic? SignedBy { get; set; }

        /// <summary>
        /// Current status of the tracking 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TrackingStatus Tag { get; set; }

        /// <summary>
        /// Origin and Destination address of shipment for specific carrier
        /// </summary>
        public TrackingAddresses Address { get; set; }

        /// <summary>
        /// Shipment weight provied by carrier (if any)
        /// </summary>
        public decimal? ShipmentWeight { get; set; }

        /// <summary>
        /// Weight unit provied by carrier, either in kg or lb (if any)
        /// </summary>
        public string? ShipmentWeightUnit { get; set; }

        /// <summary>
        /// Expected delivery date
        /// </summary>
        public DateTime? ExpectedDelivery { get; set; }

        /// <summary>
        /// Total delivery time in days.
        /// Difference of 1st checkpoint time and delivered time for delivered shipments.
        /// Difference of 1st checkpoint time and current time for non-delivered shipments.
        /// </summary>
        public int? DeliveryTime { get; set; }

        /// <summary>
        /// Shipment service type provided by carrier (if any)
        /// </summary>
        public string? ShipmentType { get; set; }

        /// <summary>
        /// Date and time the tracking was picked up
        /// </summary>
        public DateTime? ShipmentPickupDate { get; set; }

        /// <summary>
        /// Date and time the tracking was delivered
        /// </summary>
        public DateTime? ShipmentDeliveryDate { get; set; }

        /// <summary>
        /// Checkpoint information
        /// </summary>
        public IList<TrackingCheckpoint>? CheckPoints { get; set; }
    }
}
