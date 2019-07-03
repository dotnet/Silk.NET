// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.EXT.Capture
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