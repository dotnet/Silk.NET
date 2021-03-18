// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Generic interface representing an input device.
    /// </summary>
    public interface IInputDevice
    {
        /// <summary>
        /// The name of this device, as reported by the hardware.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The index of this device.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// Whether or not this device is currently connected.
        /// </summary>
        bool IsConnected { get; }
    }
}
