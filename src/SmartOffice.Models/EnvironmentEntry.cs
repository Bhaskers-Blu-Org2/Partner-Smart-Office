﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmartOffice.Models
{
    using System;

    /// <summary>
    /// Represents an environment entry.
    /// </summary>
    public class EnvironmentEntry
    {
        /// <summary>
        /// Gets or sets the application endpoint information.
        /// </summary>
        public EndpointEntry AppEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the friendly name.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the time last processed.
        /// </summary>
        public DateTimeOffset? LastProcessed { get; set; }

        /// <summary>
        /// Gets or sets the Partner Center endpoint information.
        /// </summary>
        /// <remarks>
        public EndpointEntry PartnerCenterEndpoint { get; set; }
    }
}