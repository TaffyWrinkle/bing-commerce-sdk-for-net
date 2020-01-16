// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines an expression that modifies the ranking score of results based
    /// on a condition.
    /// </summary>
    public partial class RequestBoostExpression
    {
        /// <summary>
        /// Initializes a new instance of the RequestBoostExpression class.
        /// </summary>
        public RequestBoostExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestBoostExpression class.
        /// </summary>
        /// <param name="condition">The condition that triggers a boost in
        /// ranking score.</param>
        /// <param name="boost">The magnitude of a boost. The range is -10
        /// million to 10 million.</param>
        public RequestBoostExpression(ConditionBase condition = default(ConditionBase), double? boost = default(double?))
        {
            Condition = condition;
            Boost = boost;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the condition that triggers a boost in ranking score.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public ConditionBase Condition { get; set; }

        /// <summary>
        /// Gets or sets the magnitude of a boost. The range is -10 million to
        /// 10 million.
        /// </summary>
        [JsonProperty(PropertyName = "boost")]
        public double? Boost { get; set; }

    }
}
