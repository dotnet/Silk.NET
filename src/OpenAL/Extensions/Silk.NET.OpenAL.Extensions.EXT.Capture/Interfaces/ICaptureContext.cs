//
// ICaptureContext
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
    /// Defines the public API of capture-related functions in the Capture extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    public interface ICaptureContext
    {
        /// <summary>
        /// Opens a capture device by name.
        /// </summary>
        /// <param name="deviceName">The name of the device.</param>
        /// <param name="frequency">The frequency data should be captured at.</param>
        /// <param name="format">The requested capture buffer format.</param>
        /// <param name="size">The size of the capture buffer.</param>
        /// <returns>The device pointer, or null.</returns>
        unsafe Device* CaptureOpenDevice([CallerFree] string deviceName, uint frequency, BufferFormat format, int size);

        /// <summary>
        /// Closes the specified capture device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>true if the device was closed; otherwise, false.</returns>
        unsafe bool CaptureCloseDevice(Device* device);

        /// <summary>
        /// Begins a capture operation.
        ///
        /// CaptureStart will begin recording to an internal ring buffer of the size specified when opening the capture
        /// device. The application can then retrieve the number of samples currently available using
        /// <see cref="GetCaptureContextInteger.CaptureSamples"/> with <see cref="ICaptureContextState.GetContextProperty"/>
        ///
        /// When the application determines that enough samples are available for processing, then it can obtain them
        /// with a call to <see cref="CaptureSamples"/>.
        ///
        /// </summary>
        /// <param name="device">The device.</param>
        unsafe void CaptureStart(Device* device);

        /// <summary>
        /// Stops a capture operation.
        /// </summary>
        /// <param name="device">The device.</param>
        unsafe void CaptureStop(Device* device);

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="buffer">The buffer to fill with data.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        unsafe void CaptureSamples(Device* device, void* buffer, int sampleCount);
    }
}
