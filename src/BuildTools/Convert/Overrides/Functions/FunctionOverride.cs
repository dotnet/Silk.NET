// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Type = Generator.Common.Functions.Type;

namespace Generator.Convert.Overrides.Functions
{
    /// <summary>
    /// Represents a function with overridden properties.
    /// </summary>
    public class FunctionOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionOverride" /> class.
        /// </summary>
        /// <param name="baseName">The name of the base function.</param>
        /// <param name="baseExtension">The extensions of the base function.</param>
        /// <param name="newVersion">The new version that the function was introduced in.</param>
        /// <param name="obsoletionReason">The reason the function has been made obsolete.</param>
        /// <param name="newReturnType">The new return type.</param>
        /// <param name="parameterOverrides">The parameter overrides.</param>
        public FunctionOverride
        (
            [NotNull] string baseName,
            [CanBeNull] string baseExtension,
            [CanBeNull] string newVersion,
            [CanBeNull] string obsoletionReason,
            [CanBeNull] Type newReturnType,
            [NotNull] IReadOnlyList<ParameterOverride> parameterOverrides
        )
        {
            BaseName = baseName ?? throw new ArgumentNullException(nameof(baseName));
            BaseExtension = baseExtension;
            NewVersion = newVersion;
            ObsoletionReason = obsoletionReason;
            NewReturnType = newReturnType;
            ParameterOverrides = parameterOverrides ?? throw new ArgumentNullException(nameof(parameterOverrides));
        }

        /// <summary>
        /// Gets the name of the function that the override affects.
        /// </summary>
        [NotNull]
        public string BaseName { get; }

        /// <summary>
        /// Gets the extension that the function that the override affects is in.
        /// </summary>
        [CanBeNull]
        public string BaseExtension { get; }

        /// <summary>
        /// Gets the new version that introduced the function.
        /// </summary>
        [CanBeNull]
        public string NewVersion { get; }

        /// <summary>
        /// Gets the reason the function was made obsolete.
        /// </summary>
        [CanBeNull]
        public string ObsoletionReason { get; }

        /// <summary>
        /// Gets the new return type of the function.
        /// </summary>
        [CanBeNull]
        public Type NewReturnType { get; }

        /// <summary>
        /// Gets the overridden parameters in the function.
        /// </summary>
        [NotNull]
        public IReadOnlyList<ParameterOverride> ParameterOverrides { get; }

        /// <summary>
        /// Determines if this instance has the same signature as the given instance.
        /// </summary>
        /// <param name="other">The other instance.</param>
        /// <returns>true if the instances have the same signatures; otherwise, false.</returns>
        public bool HasSameSignatureAs([NotNull] FunctionOverride other)
        {
            if (BaseName != other.BaseName)
            {
                return false;
            }

            if (NewReturnType != other.NewReturnType)
            {
                return false;
            }

            if (ParameterOverrides.Count != other.ParameterOverrides.Count)
            {
                return false;
            }

            // Parameters must match based on type and position
            return !ParameterOverrides.Where((t, i) => t.NewType != other.ParameterOverrides[i].NewType).Any();
        }
    }
}
