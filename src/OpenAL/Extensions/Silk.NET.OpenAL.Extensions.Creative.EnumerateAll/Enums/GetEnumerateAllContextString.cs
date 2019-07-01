// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Defines available parameters for <see cref="IEnumerateAllContextState.GetString" />.
    /// </summary>
    public enum GetEnumerateAllContextString
    {
        /// <summary>
        /// Gets the specifier for the default device.
        /// </summary>
        DefaultAllDevicesSpecifier = 0x1012,

        /// <summary>
        /// Gets the specifier of the first available device.
        /// </summary>
        AllDevicesSpecifier = 0x1013
    }
}