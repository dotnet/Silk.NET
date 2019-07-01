//
// ICaptureContextState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Defines the public API of state-related functions in the Capture extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    public interface ICaptureContextState
    {
        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="count">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        [NativeSymbol("GetIntegerv")]
        unsafe void GetContextProperty(Device* device, GetCaptureContextInteger param, int count, void* data);
    }
}
