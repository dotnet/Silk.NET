// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Represents an overloader that operates on the whole function, and has full control over the implementation.
    /// </summary>
    public interface IComplexFunctionOverloader
    {
        /// <summary>
        /// Attempts to overload the given function.
        /// </summary>
        /// <param name="original">The input function.</param>
        /// <param name="varied">The varied/overloaded function, or null if this overloader is not applicable.</param>
        /// <param name="core">The core project for this profile, should the overloader need it.</param>
        /// <returns>
        /// True if this overloader is applicable and an overload was successfully generated, false otherwise.
        /// </returns>
        bool TryGetFunctionVariant(Function original, out ImplementedFunction varied, Project core);
    }
}
