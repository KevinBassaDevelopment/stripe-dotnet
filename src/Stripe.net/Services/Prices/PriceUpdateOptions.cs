namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the price can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A brief description of the price, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The recurring components of a price such as its interval.
        /// </summary>
        [JsonProperty("recurring")]
        public PriceRecurringOptions Recurring { get; set; }

        /// <summary>
        /// If set to <c>true</c>, will atomically remove the lookup key from the existing price,
        /// and assign it to this price.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
