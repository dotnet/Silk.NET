using System.Collections.Generic;
using Generator.Common.Functions;
using JetBrains.Annotations;

namespace Generator.Bind.Overloading
{
    /// <summary>
    /// Represents a class that can create a set of overloads from a given base signature.
    /// </summary>
    public interface IFunctionOverloader
    {
        /// <summary>
        /// Determines whether or not the overloader is applicable for the given function.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <returns>true if the overloader is applicable; otherwise, false.</returns>
        bool IsApplicable([NotNull] Function function);

        /// <summary>
        /// Creates a set of overload signatures from the given function.
        /// </summary>
        /// <param name="function">The base function.</param>
        /// <returns>A set of code blocks.</returns>
        [NotNull]
        IEnumerable<Overload> CreateOverloads([NotNull] Function function);
    }
}
