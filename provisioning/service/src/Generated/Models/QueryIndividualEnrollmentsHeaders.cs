// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for QueryIndividualEnrollments operation.
    /// </summary>
    public partial class QueryIndividualEnrollmentsHeaders
    {
        /// <summary>
        /// Initializes a new instance of the QueryIndividualEnrollmentsHeaders
        /// class.
        /// </summary>
        public QueryIndividualEnrollmentsHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryIndividualEnrollmentsHeaders
        /// class.
        /// </summary>
        /// <param name="xMsContinuation">The continuation token for getting
        /// the next page of results.</param>
        /// <param name="xMsMaxItemCount">The maximum number of items returned
        /// in a page.</param>
        /// <param name="xMsItemType">The query result type.</param>
        public QueryIndividualEnrollmentsHeaders(string xMsContinuation = default(string), int? xMsMaxItemCount = default(int?), string xMsItemType = default(string))
        {
            XMsContinuation = xMsContinuation;
            XMsMaxItemCount = xMsMaxItemCount;
            XMsItemType = xMsItemType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the continuation token for getting the next page of
        /// results.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-continuation")]
        public string XMsContinuation { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items returned in a page.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-max-item-count")]
        public int? XMsMaxItemCount { get; set; }

        /// <summary>
        /// Gets or sets the query result type.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-item-type")]
        public string XMsItemType { get; set; }

    }
}