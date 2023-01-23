// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        /// <param name="core">The profile, should the overloader need it.</param>
        /// <returns>
        /// True if this overloader is applicable and a parameter overload was successfully generated, false otherwise.
        /// </returns>
        bool TryGetParameterVariant(Parameter parameter, out Parameter varied, Profile profile);
    }
}
