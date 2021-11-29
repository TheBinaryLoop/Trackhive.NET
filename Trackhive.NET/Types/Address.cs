namespace Trackhive.NET.Types
{
    public class Address
    {
        /// <summary>
        /// Street 1 address
        /// </summary>
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Street 2 address
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Name of the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Name of the state
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// Postal code of the address
        /// </summary>
        public string? ZipCode { get; set; }

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
    }
}
