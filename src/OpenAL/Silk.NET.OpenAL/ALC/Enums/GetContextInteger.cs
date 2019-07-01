//
// GetContextInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Silk.NET.OpenAL.Interfaces;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Defines available parameters for <see cref="IContextState.GetContextProperty(Device*, GetContextInteger, int, System.IntPtr)"/>.
    /// </summary>
    public enum GetContextInteger
    {
        /// <summary>
        /// The specification revision for this implementation (major version). NULL is an acceptable device.
        /// </summary>
        MajorVersion = 0x1000,

        /// <summary>
        /// The specification revision for this implementation (minor version). NULL is an acceptable device.
        /// </summary>
        MinorVersion = 0x1001,

        /// <summary>
        /// The size (number of ALCint values) required for a zero-terminated attributes list, for the current context.
        /// NULL is an invalid device.
        /// </summary>
        AttributesSize = 0x1002,

        /// <summary>
        /// Expects a destination of ALC_ATTRIBUTES_SIZE, and provides an attribute list for the current context of the
        /// specified device. NULL is an invalid device.
        /// </summary>
        AllAttributes = 0x1003,
    }
}
