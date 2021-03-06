// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Storage quota.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageQuota : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageQuota class.
        /// </summary>
        public StorageQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageQuota class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="numberOfStorageAccounts">Total number of storage
        /// accounts.</param>
        /// <param name="capacityInGb">Maxium capacity (GB).</param>
        public StorageQuota(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? numberOfStorageAccounts = default(int?), int? capacityInGb = default(int?))
            : base(id, name, type, location, tags)
        {
            NumberOfStorageAccounts = numberOfStorageAccounts;
            CapacityInGb = capacityInGb;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets total number of storage accounts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfStorageAccounts")]
        public int? NumberOfStorageAccounts { get; set; }

        /// <summary>
        /// Gets or sets maxium capacity (GB).
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacityInGb")]
        public int? CapacityInGb { get; set; }

    }
}
