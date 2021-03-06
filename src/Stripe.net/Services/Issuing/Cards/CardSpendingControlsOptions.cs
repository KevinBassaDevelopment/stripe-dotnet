namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardSpendingControlsOptions : INestedOptions
    {
        /// <summary>
        /// Categories of authorizations permitted for this card.
        /// </summary>
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Categories of authorizations to always decline for this card.
        /// </summary>
        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        /// <summary>
        /// Limit the spending with rules based on time intervals and categories.
        /// </summary>
        [JsonProperty("spending_limits")]
        public List<CardSpendingControlsSpendingLimitOptions> SpendingLimits { get; set; }

        /// <summary>
        /// Currency for the amounts within <see cref="SpendingLimits"/>. Locked to the currency of
        /// the card.
        /// </summary>
        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
