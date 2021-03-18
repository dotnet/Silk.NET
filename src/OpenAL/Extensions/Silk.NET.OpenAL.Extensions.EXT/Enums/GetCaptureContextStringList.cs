// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT.Enumeration
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