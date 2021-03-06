namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsLodging : StripeEntity<TransactionPurchaseDetailsLodging>
    {
        /// <summary>
        /// The time of checking into the lodging.
        /// </summary>
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        /// <summary>
        /// The number of nights stayed at the lodging.
        /// </summary>
        [JsonProperty("nights")]
        public long? Nights { get; set; }
    }
}
