// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
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