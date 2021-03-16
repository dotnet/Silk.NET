// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Specifies connected state of devices.
    /// </summary>
    public enum ConnectedState
    {
        /// <summary>
        /// Indicates that a device is connected.
        /// </summary>
        Connected = 0x00040001,

        /// <summary>
        /// Indicates that a device is disconnected.
        /// </summary>
        Disconnected = 0x00040002
    }
}