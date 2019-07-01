//
// XRamGetInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Creative.XRam
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="IXRam.GetInteger"/> parameters.
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
        FreeRam,
    }
}
