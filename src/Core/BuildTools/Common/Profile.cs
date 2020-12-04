// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a subsystem as defined in GitHub issue #823.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project" />s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; } = new Dictionary<string, Project>();

        /// <summary>
        /// Gets or sets the root namespace of this profile.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the root namespace of extensions contained within this profile.
        /// </summary>
        public string ExtensionsNamespace { get; set; }

        /// <summary>
        /// Gets or sets the output folder in which the projects are wrote.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of this profile, as defined by the Khronos spec. File names should be used for
        /// colloquial names.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the mixed-mode class.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the version of this profile.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the prefix that's appended to function native names.
        /// </summary>
        public string FunctionPrefix { get; set; }

        /// <summary>
        /// Gets or sets the name of the symbol loader.
        /// </summary>
        public string SymbolLoaderName { get; set; }

        /// <summary>
        /// Gets or sets the name container for this profile.
        /// </summary>
        public NameContainer Names { get; set; } = new NameContainer();

        /// <summary>
        /// Gets or sets this profile's constants.
        /// </summary>
        public List<Constant> Constants { get; set; } = new List<Constant>();

        /// <summary>
        /// Gets or sets a list of type maps to be applied to the projects in the order in which they're applied.
        /// </summary>
        [JsonIgnore]
        public List<Dictionary<string, string>> TypeMaps { get; set; } = new List<Dictionary<string, string>>();
    }
}
