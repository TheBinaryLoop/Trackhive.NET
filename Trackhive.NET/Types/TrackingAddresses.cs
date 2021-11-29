namespace Trackhive.NET.Types
{
    public class TrackingAddresses
    {
        /// <summary>
        /// Origin address of the shipment
        /// </summary>
        public Address ShipFrom { get; set; }

        /// <summary>
        /// Destination address of the shipment
        /// </summary>
        public Address ShipTo { get; set; }
    }
}
