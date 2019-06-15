using System.Collections.Generic;

namespace Generator.Convert.Documentation
{
    /// <summary>
    /// Represents parsed documentation for all functions in a profile.
    /// </summary>
    public class ProfileDocumentation
    {
        /// <summary>
        /// Gets or sets a dictionary where the function name (without the prefix) is the key, and its documentation
        /// is the value.
        /// </summary>
        public Dictionary<string, FunctionDocumentation> Functions { get; set; }
    }
}
