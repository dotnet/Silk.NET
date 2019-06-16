// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Generator.Convert.Overrides.Enumerations;
using Generator.Convert.Overrides.Functions;
using JetBrains.Annotations;

namespace Generator.Convert.Overrides
{
    /// <summary>
    /// Represents a set of overridden APIs in a given profile.
    /// </summary>
    public class ApiProfileOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileOverride" /> class.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <param name="versions">The versions the profile encompasses.</param>
        /// <param name="addedEnumerations">The added enumerations.</param>
        /// <param name="replacedFunctions">The replaced functions.</param>
        public ApiProfileOverride
        (
            [NotNull] string name,
            [NotNull] string versions,
            [NotNull] IReadOnlyList<EnumerationOverride> addedEnumerations,
            [NotNull] IReadOnlyList<FunctionOverride> replacedFunctions
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Version = versions ?? throw new ArgumentNullException(nameof(versions));
            AddedEnumerations = addedEnumerations ?? throw new ArgumentNullException(nameof(addedEnumerations));
            ReplacedFunctions = replacedFunctions ?? throw new ArgumentNullException(nameof(replacedFunctions));
        }

        /// <summary>
        /// Gets the name of the profile to which these overrides apply.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the version of the profile to which these overrides apply.
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Gets the enumerations that were added to the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<EnumerationOverride> AddedEnumerations { get; }

        /// <summary>
        /// Gets the functions that were replaced in the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionOverride> ReplacedFunctions { get; }

        /// <summary>
        /// Gets the function overloads that were added to the profile.
        /// </summary>
        [NotNull]
        [Obsolete("Overloads have been moved to helper classes.", true)]
        public IReadOnlyList<FunctionOverride> FunctionOverloads { get; }
    }
}
