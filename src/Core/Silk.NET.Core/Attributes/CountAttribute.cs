// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core.Attributes
{
    /// <summary>
    /// Represents the count of a parameter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class CountAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the static count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the deterministic parameter for this count.
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets the computed count.
        /// </summary>
        public string Computed { get; set; }

        /// <summary>
        /// Gets or sets the mathematical expression corresponding with this count. Used in conjunction with
        /// <see cref="Parameter"/>.
        /// </summary>
        public string Expression { get; set; }
    }
}
