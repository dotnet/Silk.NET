// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines available parameters for
    /// <see cref="IEnumerationContextState.GetStringList(Device*, GetEnumerationContextStringList)" />.
    /// </summary>
    public enum GetEnumerationContextStringList
    {
        /// <summary>
        /// The specifier strings for all available devices. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifiers = 0x1005
    }
}