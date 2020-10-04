// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a project, whether root or extension, containing <see cref="Interface" />s and <see cref="Enum" />s.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets or sets the name of the extension this project is categorised under.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets the category name of this project.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the root namespace of this project. This is also used as the assembly name.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this project is the root project, or an extension.
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// Gets or sets a list of <see cref="Enum" />s contained within this <see cref="Project" />.
        /// </summary>
        public List<Enum> Enums { get; set; } = new List<Enum>();

        /// <summary>
        /// Gets or sets a dictionary where the category names are the keys, and <see cref="Interface" />s
        /// are the values.
        /// </summary>
        public Dictionary<string, Interface> Interfaces { get; set; } = new Dictionary<string, Interface>();

        /// <summary>
        /// Gets or sets this project's list of structs.
        /// </summary>
        public List<Struct> Structs { get; set; } = new List<Struct>();

        /// <summary>
        /// Gets or sets this project's list of delegate functions.
        /// </summary>
        public List<Function> Delegates { get; set; } = new List<Function>();

        /// <summary>
        /// Gets the full project name of this project, given the profile's root namespace.
        /// </summary>
        /// <param name="profile">The profile to use for the root namespace.</param>
        /// <returns>The full project name.</returns>
        public string GetProjectName(Profile profile)
        {
            return GetNamespace(profile);
        }

        /// <summary>
        /// Gets the full namespace of this project, given the profile's root namespace.
        /// </summary>
        /// <param name="profile">The profile to use for the root namespace.</param>
        /// <returns>The full namespace.</returns>
        public string GetNamespace(Profile profile)
        {
            return (!IsRoot ? profile.ExtensionsNamespace : profile.Namespace) + Namespace;
        }
    }
}
