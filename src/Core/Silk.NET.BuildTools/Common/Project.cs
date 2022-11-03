// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Enums;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a project, whether root or extension, containing <see cref="NativeApiSet" />s and <see cref="Enum" />s.
    /// </summary>
    public class Project
    {
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
        /// Gets or sets this project's list of structs.
        /// </summary>
        public List<Struct> Structs { get; set; } = new List<Struct>();

        /// <summary>
        /// GEts or sets this project's list of classes.
        /// </summary>
        public List<Class> Classes { get; set; } = new List<Class>();

        /// <summary>
        /// Gets or sets the references to external COM interfaces.
        /// </summary>
        public HashSet<string> ComRefs { get; set; } = new();

        /// <summary>
        /// Gets the full project name of this project, given the profile's root namespace.
        /// </summary>
        /// <returns>The full project name.</returns>
        public string GetProjectName(BindTask task)
        {
            return GetNamespace(task);
        }

        /// <summary>
        /// Gets the full namespace of this project, given the profile's root namespace.
        /// </summary>
        /// <returns>The full namespace.</returns>
        public string GetNamespace(BindTask taskConfig)
        {
            return (!IsRoot ? taskConfig.ExtensionsNamespace : taskConfig.Namespace) + Namespace;
        }
    }
}
