using System;
using JetBrains.Annotations;

namespace Generator.Convert.Overrides.Enumerations
{
    /// <summary>
    /// Represents an override inclusion of a token from another enumeration.
    /// </summary>
    public class UseTokenOverride
    {
        /// <summary>
        /// Gets the name of the token to include.
        /// </summary>
        [NotNull]
        public string Token { get; }

        /// <summary>
        /// Gets the name of the enumeration to search for the token in. If not present,
        /// the first found occurrence is used.
        /// </summary>
        [CanBeNull]
        public string Enumeration { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UseTokenOverride"/> class.
        /// </summary>
        /// <param name="token">The name of the token to use.</param>
        /// <param name="enumeration">The name of the enumeration to search.</param>
        public UseTokenOverride([NotNull] string token, [CanBeNull] string enumeration)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
            Enumeration = enumeration;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{(Enumeration is null ? string.Empty : $"{Enumeration}::")}{Token}";
        }
    }
}
