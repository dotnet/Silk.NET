using System.Collections.Generic;

namespace Generator.Common.Functions
{
    /// <summary>
    /// Represents a C# generic type parameter.
    /// </summary>
    public class GenericTypeParameter
    {
        /// <summary>
        /// Gets or sets the name of this generic type parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of generic type parameter constraints.
        /// </summary>
        public List<string> Constraints { get; set; } = new List<string>();
    }
}
