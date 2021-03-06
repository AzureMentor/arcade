// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UnknownWorkItemEvent
    {
        /// <summary>
        /// Initializes a new instance of the UnknownWorkItemEvent class.
        /// </summary>
        public UnknownWorkItemEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnknownWorkItemEvent class.
        /// </summary>
        public UnknownWorkItemEvent(string type = default(string), System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), IDictionary<string, string> values = default(IDictionary<string, string>))
        {
            Type = type;
            Timestamp = timestamp;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IDictionary<string, string> Values { get; set; }

    }
}
