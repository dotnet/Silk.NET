// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Defines available parameters for <see cref="IContextState.GetContextProperty(Device*,GetContextString)" />.
    /// </summary>
    public enum GetContextString
    {
        /// <summary>
        /// A list of available context extensions separated by spaces.
        /// </summary>
        Extensions = 0x1006,

        /// <summary>
        /// Gets the name of the provided device.
        /// </summary>
        DeviceSpecifier = 0x1005
    }
}