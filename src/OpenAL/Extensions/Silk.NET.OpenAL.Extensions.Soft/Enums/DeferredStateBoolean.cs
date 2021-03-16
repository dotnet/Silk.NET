// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="bool" /> <see cref="IDeferredUpdatesState.GetBoolean" /> parameters.
    /// </summary>
    public enum DeferredStateBoolean
    {
        /// <summary>
        /// Determines whether or not updates are currently deferred.
        /// </summary>
        /// <seealso cref="IDeferredUpdatesState.DeferUpdates" />
        /// <seealso cref="IDeferredUpdatesState.ProcessUpdates" />
        AreUpdatesDeferred = 0xC002
    }
}