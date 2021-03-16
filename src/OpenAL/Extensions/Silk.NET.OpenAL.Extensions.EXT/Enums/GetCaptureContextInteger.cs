// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Defines valid values for the <see cref="ICaptureContextState.GetContextProperty" /> method.
    /// </summary>
    public enum GetCaptureContextInteger
    {
        /// <summary>
        /// The number of capture samples available. NULL is an invalid device.
        /// </summary>
        CaptureSamples = 0x312
    }
}