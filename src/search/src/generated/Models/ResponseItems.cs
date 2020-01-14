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
    /// Defines a list of items from the result set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Items")]
    public partial class ResponseItems : ResponseItemsBase
    {
        /// <summary>
        /// Initializes a new instance of the ResponseItems class.
        /// </summary>
        public ResponseItems()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseItems class.
        /// </summary>
        /// <param name="errors">A list of errors that happened to the task, if
        /// any.</param>
        /// <param name="totalEstimatedMatches">An estimated count of the items
        /// in the full result set.</param>
        /// <param name="value">The item results. May be limited by
        /// pagination.</param>
        public ResponseItems(IList<ResponseError> errors = default(IList<ResponseError>), IList<ResponseDebugInfo> debug = default(IList<ResponseDebugInfo>), long? totalEstimatedMatches = default(long?), IList<ResponseItem> value = default(IList<ResponseItem>))
            : base(errors, debug, totalEstimatedMatches)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the item results. May be limited by pagination.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ResponseItem> Value { get; set; }

    }
}