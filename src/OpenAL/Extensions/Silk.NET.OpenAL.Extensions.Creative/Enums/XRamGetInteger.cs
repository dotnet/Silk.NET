// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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