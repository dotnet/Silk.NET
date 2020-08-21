// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Represents an overloader that operates on one parameter, and generates SilkTouch-compatible overloads.
    /// </summary>
    public interface ISimpleParameterOverloader
    {
        /// <summary>
        /// Attempts to overload the given parameter.
        /// </summary>
        /// <param name="parameter">The input parameter.</param>
        /// <param name="varied">The varied/overloaded parameter, or null if this overloader is not applicable.</param>
        /// <param name="core">The core project for this profile, should the overloader need it.</param>
        /// <returns>
        /// True if this overloader is applicable and a parameter overload was successfully generated, false otherwise.
        /// </returns>
        bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Project core);
    }
}
