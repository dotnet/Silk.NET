using System;
using System.Collections.Generic;
using Generator.Common.Enums;
using JetBrains.Annotations;

namespace Generator.Convert.Overrides.Enumerations
{
    /// <summary>
    /// Represents an enumeration definition in an API, which has been overridden.
    /// </summary>
    public class EnumerationOverride
    {
        /// <summary>
        /// Gets the name of the enumeration.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the set of tokens contained in the enumeration.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<Token> DirectTokens { get; internal set; }

        /// <summary>
        /// Gets the set of token references contained in the enumeration. These are resolved in the baking step.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<UseTokenOverride> UseTokens { get; internal set; }

        /// <summary>
        /// Gets the set of enumeration reuse references contained in the enumeration. These are resolved in the baking
        /// step.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<ReuseEnumerationOverride> ReuseEnumerations { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationOverride"/> class.
        /// </summary>
        /// <param name="name">The name of the enumeration.</param>
        /// <param name="directTokens">The tokens contained in the enumeration.</param>
        /// <param name="useTokens">The set of token references contained in the enumeration.</param>
        /// <param name="reuseEnumerations">The set of enumeration reuse references contained in the enumeration.</param>
        public EnumerationOverride
        (
            [NotNull] string name,
            [CanBeNull, ItemNotNull] List<Token> directTokens = null,
            [CanBeNull, ItemNotNull] IReadOnlyList<UseTokenOverride> useTokens = null,
            [CanBeNull, ItemNotNull] IReadOnlyList<ReuseEnumerationOverride> reuseEnumerations = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));

            DirectTokens = directTokens ?? new List<Token>();
            UseTokens = useTokens ?? new List<UseTokenOverride>();
            ReuseEnumerations = reuseEnumerations ?? new List<ReuseEnumerationOverride>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"enum {Name} {{ ... }}";
        }
    }
}
