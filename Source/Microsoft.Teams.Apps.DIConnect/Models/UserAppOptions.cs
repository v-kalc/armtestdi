// <copyright file="UserAppOptions.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.DIConnect.Models
{
    /// <summary>
    /// Teams User options for app configuration.
    /// </summary>
    public class UserAppOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether user app should be pro actively installed.
        /// </summary>
        public bool ProactivelyInstallUserApp { get; set; }

        /// <summary>
        /// Gets or sets User app's external Id (id in the manifest).
        /// </summary>
        public string UserAppExternalId { get; set; }
    }
}