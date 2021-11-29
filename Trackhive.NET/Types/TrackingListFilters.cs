using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Trackhive.NET.Types
{
    public class TrackingListFilters
    {
        public string? Courier { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TrackingStatus? Status { get; set; }
    }
}
