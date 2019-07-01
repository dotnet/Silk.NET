// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines the public API of the context-related functions of the Capture extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface ICaptureEnumerationContextState
    {
        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        unsafe string GetString(Device* device, GetCaptureEnumerationContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe char* GetStringList(Device* device, GetCaptureContextStringList param);
    }
}