// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using JetBrains.Annotations;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    /// <summary>
    /// Represents a class that can create a set of overloads from a given base signature.
    /// </summary>
    public interface IFunctionOverloader
    {
        /// <summary>
        /// Creates a set of overload signatures from the given function.
        /// </summary>
        /// <param name="function">The base function.</param>
        /// <returns>A set of code blocks.</returns>
        [NotNull]
        IEnumerable<ImplementedFunction> CreateOverloads([NotNull] Function function);
    }
}
