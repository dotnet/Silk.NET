// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a native API profile.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project" />s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; } = new Dictionary<string, Project>();

        /// <summary>
        /// Gets or sets the name of this profile, as defined by the Khronos spec. File names should be used for
        /// colloquial names.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the version of this profile.
        /// </summary>
        public string Version { get; set; }
    }
}
