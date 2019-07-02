// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Soft.DeferredUpdates
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