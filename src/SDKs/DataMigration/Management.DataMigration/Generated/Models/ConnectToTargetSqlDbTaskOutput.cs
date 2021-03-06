// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for the task that validates connection to SQL DB and target
    /// server requirements
    /// </summary>
    public partial class ConnectToTargetSqlDbTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the ConnectToTargetSqlDbTaskOutput
        /// class.
        /// </summary>
        public ConnectToTargetSqlDbTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectToTargetSqlDbTaskOutput
        /// class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="databases">Source databases as a map from database
        /// name to database id</param>
        /// <param name="targetServerVersion">Version of the target
        /// server</param>
        /// <param name="targetServerBrandVersion">Target server brand
        /// version</param>
        public ConnectToTargetSqlDbTaskOutput(string id = default(string), IDictionary<string, string> databases = default(IDictionary<string, string>), string targetServerVersion = default(string), string targetServerBrandVersion = default(string))
        {
            Id = id;
            Databases = databases;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets source databases as a map from database name to database id
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IDictionary<string, string> Databases { get; private set; }

        /// <summary>
        /// Gets version of the target server
        /// </summary>
        [JsonProperty(PropertyName = "targetServerVersion")]
        public string TargetServerVersion { get; private set; }

        /// <summary>
        /// Gets target server brand version
        /// </summary>
        [JsonProperty(PropertyName = "targetServerBrandVersion")]
        public string TargetServerBrandVersion { get; private set; }

    }
}
