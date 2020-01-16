// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A response representing the status of a transformation config tryout
    /// requset.
    /// </summary>
    public partial class TransformationTryoutResponse
    {
        /// <summary>
        /// Initializes a new instance of the TransformationTryoutResponse
        /// class.
        /// </summary>
        public TransformationTryoutResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransformationTryoutResponse
        /// class.
        /// </summary>
        /// <param name="status">The status of the transformation config
        /// tryout.</param>
        /// <param name="errorMessage">Any error messages that happened while
        /// transforming, if any.</param>
        /// <param name="results">A list of records that the transformation
        /// config outputed.</param>
        /// <param name="consoleOutput">The console output of the
        /// transformation config, if any. Can be useful for debugging.</param>
        public TransformationTryoutResponse(string status = default(string), string errorMessage = default(string), IList<string> results = default(IList<string>), IList<string> consoleOutput = default(IList<string>))
        {
            Status = status;
            ErrorMessage = errorMessage;
            Results = results;
            ConsoleOutput = consoleOutput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the transformation config tryout.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets any error messages that happened while transforming,
        /// if any.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a list of records that the transformation config
        /// outputed.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<string> Results { get; set; }

        /// <summary>
        /// Gets or sets the console output of the transformation config, if
        /// any. Can be useful for debugging.
        /// </summary>
        [JsonProperty(PropertyName = "consoleOutput")]
        public IList<string> ConsoleOutput { get; set; }

    }
}
