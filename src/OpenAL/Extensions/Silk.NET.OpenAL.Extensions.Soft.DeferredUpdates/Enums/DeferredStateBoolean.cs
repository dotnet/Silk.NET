//
// DeferredStateBoolean.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Soft.DeferredUpdates
{
    /// <summary>
    /// A list of valid <see cref="bool"/> <see cref="IDeferredUpdatesState.GetBoolean"/> parameters.
    /// </summary>
    public enum DeferredStateBoolean
    {
        /// <summary>
        /// Determines whether or not updates are currently deferred.
        /// </summary>
        /// <seealso cref="IDeferredUpdatesState.DeferUpdates"/>
        /// <seealso cref="IDeferredUpdatesState.ProcessUpdates"/>
        AreUpdatesDeferred = 0xC002,
    }
}
