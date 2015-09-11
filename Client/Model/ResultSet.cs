namespace Transavia.Api.FlightOffers.Client.Model
{
    public class ResultSet
    {
        /// <summary>
        /// The number of results.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Reference to next result set.
        /// </summary>
        public Link NextOffsetLink { get; set; }
    }
}