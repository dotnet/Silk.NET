// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Contracts;

namespace Silk.NET.BuildTools.Common.Trimmers
{
    /// <summary>
    /// Represents a class that can trim the identifier for some type in some fashion.
    /// </summary>
    /// <typeparam name="TTrimmable">The trimmable type.</typeparam>
    public interface ITrimmer<TTrimmable>
    {
        /// <summary>
        /// Determines if the name trimmer is relevant for the given type.
        /// </summary>
        /// <param name="trimmable">The type to check.</param>
        /// <returns>true if the name trimmer is relevant; otherwise, false.</returns>
        bool IsRelevant(TTrimmable trimmable);

        /// <summary>
        /// Trims the given type.
        /// </summary>
        /// <param name="trimmable">The type to trim.</param>
        /// <param name="prefix">The prefix.</param>
        [Pure]
        TTrimmable Trim(TTrimmable trimmable, string prefix);
    }
}
