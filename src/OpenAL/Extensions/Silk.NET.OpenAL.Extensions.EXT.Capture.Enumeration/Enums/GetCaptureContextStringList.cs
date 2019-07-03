// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines available parameters for
    /// <see cref="ICaptureEnumerationContextState.GetStringList(Device*,GetCaptureContextStringList)" />.
    /// </summary>
    public enum GetCaptureContextStringList
    {
        /// <summary>
        /// Gets the names of the available capture device specifiers.
        /// </summary>
        CaptureDeviceSpecifiers = 0x310
    }
}