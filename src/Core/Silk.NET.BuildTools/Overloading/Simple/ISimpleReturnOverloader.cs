// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Represents an overloader that operates on one return type, and generates SilkTouch-compatible overloads.
    /// </summary>
    public interface ISimpleReturnOverloader
    {
        /// <summary>
        /// Attempts to overload the given return type.
        /// </summary>
        /// <param name="returnType">The input return type.</param>
        /// <param name="varied">The varied/overloaded return type, or null if this overloader is not applicable.</param>
        /// <param name="core">The core project for this profile, should the overloader need it.</param>
        /// <returns>
        /// True if this overloader is applicable and a return type overload was successfully generated, false otherwise.
        /// </returns>
        bool TryGetReturnTypeVariant(Type returnType, out Type varied, Project core);
    }
}
