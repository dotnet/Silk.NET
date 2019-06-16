// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using JetBrains.Annotations;

namespace Generator.Convert.Overrides.Enumerations
{
    /// <summary>
    /// Represents an override inclusion of the members of another enumeration.
    /// </summary>
    public class ReuseEnumerationOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseEnumerationOverride" /> class.
        /// </summary>
        /// <param name="enumeration">The name of the enumeration to reuse.</param>
        public ReuseEnumerationOverride([NotNull] string enumeration)
        {
            Enumeration = enumeration ?? throw new ArgumentNullException(nameof(enumeration));
        }

        /// <summary>
        /// Gets the name of the enumeration to reuse the tokens of.
        /// </summary>
        [NotNull]
        public string Enumeration { get; }

        /// <inheritdoc />
        public override string ToString()
        {
            return Enumeration;
        }
    }
}
