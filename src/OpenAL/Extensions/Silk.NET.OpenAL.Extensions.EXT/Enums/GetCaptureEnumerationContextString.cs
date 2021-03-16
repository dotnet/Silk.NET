// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT.Enumeration
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