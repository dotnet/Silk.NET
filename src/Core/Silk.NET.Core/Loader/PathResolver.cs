// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    ///     Enumerates possible library load targets.
    /// </summary>
    public abstract class PathResolver
    {
        /// <summary>
        ///     Gets a default path resolver.
        /// </summary>
        public static PathResolver Default { get; } = new DefaultPathResolver();

        /// <summary>
        ///     Returns an enumerator which yields possible library load targets, in priority order.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <returns>An enumerator yielding load targets.</returns>
        public abstract IEnumerable<string> EnumeratePossibleLibraryLoadTargets(string name);
    }
}
