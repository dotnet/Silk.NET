// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A list of valid <see cref="int" /> <see cref="IXRam.GetInteger" /> parameters.
    /// </summary>
    public enum XRamGetInteger
    {
        /// <summary>
        /// Gets the total amount of available X-RAM in bytes.
        /// </summary>
        RamSize,

        /// <summary>
        /// Gets the amount of free X-RAM in bytes.
        /// </summary>
        FreeRam
    }
}