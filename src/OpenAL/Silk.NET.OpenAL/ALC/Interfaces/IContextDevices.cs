// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the device-related context functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    public interface IContextDevices
    {
        /// <summary>
        /// Opens a device by name.
        /// </summary>
        /// <param name="deviceName">The name of the device.</param>
        /// <returns>The pointer to the device.</returns>
        unsafe Device* OpenDevice([CallerFree] string deviceName);

        /// <summary>
        /// Closes the given device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>true if the device was closed; otherwise, false.</returns>
        unsafe bool CloseDevice(Device* device);
    }
}