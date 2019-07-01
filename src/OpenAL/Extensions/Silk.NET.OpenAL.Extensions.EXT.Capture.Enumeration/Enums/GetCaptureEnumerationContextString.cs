// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines available parameters for
    /// <see cref="ICaptureEnumerationContextState.GetString(Device*,GetCaptureEnumerationContextString)" />.
    /// </summary>
    public enum GetCaptureEnumerationContextString
    {
        /// <summary>
        /// Gets the name of the default capture device
        /// </summary>
        DefaultCaptureDeviceSpecifier = 0x311,

        /// <summary>
        /// Gets the first available capture device specifier.
        /// </summary>
        CaptureDeviceSpecifier = 0x310
    }
}