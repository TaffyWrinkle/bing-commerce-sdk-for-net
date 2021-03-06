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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Aggregation type for getting the max value of a field. Only applicable
    /// to numeric data.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Max")]
    public partial class RequestMax : RequestFieldAggregationBase
    {
        /// <summary>
        /// Initializes a new instance of the RequestMax class.
        /// </summary>
        public RequestMax()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequestMax class.
        /// </summary>
        /// <param name="name">A label that you specify for your aggregations,
        /// which the API passes through and returns with the response.</param>
        /// <param name="aggregations">A list of child aggregations.</param>
        /// <param name="field">The field name.</param>
        public RequestMax(string name = default(string), IList<RequestAggregationBase> aggregations = default(IList<RequestAggregationBase>), string field = default(string))
            : base(name, aggregations, field)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
