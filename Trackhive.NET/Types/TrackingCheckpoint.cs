using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Trackhive.NET.Types
{
    public class TrackingCheckpoint
    {
        /// <summary>
        /// The unique code of courier for this checkpoint message
        /// </summary>
        public string? Slug { get; set; }

        /// <summary>
        /// Date and time the tracking was created
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Current status of the check point 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TrackingStatus? Tag { get; set; }

        /// <summary>
        /// Checkpoint message
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// City info provided by carrier (if any)
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// State info provided by carrier (if any)
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        public string? Zip { get; set; }

        /// <summary>
        /// 2 digit ISO code of country
        /// </summary>
        public string? CountryIso { get; set; }

        /// <summary>
        /// 3 digit ISO code of country
        /// </summary>
        public string? CountryIso3 { get; set; }

        /// <summary>
        /// Country name of the checkpoint, may also contain other location info
        /// </summary>
        public string? CountryName { get; set; }

        /// <summary>
        /// Location info provided by carrier (if any)
        /// </summary>
        public string? Location { get; set; }
    }
}
