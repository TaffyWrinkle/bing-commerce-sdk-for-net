// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A response to a push data update.
    /// </summary>
    public partial class PushDataUpdateResponse
    {
        /// <summary>
        /// Initializes a new instance of the PushDataUpdateResponse class.
        /// </summary>
        public PushDataUpdateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PushDataUpdateResponse class.
        /// </summary>
        /// <param name="updateId">The id of the push data update that you can
        /// use to track it down.</param>
        public PushDataUpdateResponse(string updateId = default(string))
        {
            UpdateId = updateId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the push data update that you can use to
        /// track it down.
        /// </summary>
        [JsonProperty(PropertyName = "updateId")]
        public string UpdateId { get; set; }

    }
}