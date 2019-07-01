//
// GetCaptureContextStringList.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines available parameters for <see cref="ICaptureEnumerationContextState.GetStringList(Device*,GetCaptureContextStringList)" />.
    /// </summary>
    public enum GetCaptureContextStringList
    {
        /// <summary>
        /// Gets the names of the available capture device specifiers.
        /// </summary>
        CaptureDeviceSpecifiers = 0x310,
    }
}
