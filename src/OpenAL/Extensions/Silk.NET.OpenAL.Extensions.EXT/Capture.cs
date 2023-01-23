// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Attributes;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the API in the Capture extension.
    /// </summary>
    [Extension("ALC_EXT_CAPTURE")]
    [NativeApi(Prefix = "alc")]
    public partial class Capture : ContextExtensionBase
    {
        /// <inheritdoc cref="ExtensionBase" />
        public Capture(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public unsafe partial Device* CaptureOpenDevice(string deviceName, uint frequency, BufferFormat format,
            int size);

        /// <inheritdoc />
        public unsafe partial bool CaptureCloseDevice(Device* device);

        /// <inheritdoc />
        public unsafe partial void CaptureStart(Device* device);

        /// <inheritdoc />
        public unsafe partial void CaptureStop(Device* device);

        /// <inheritdoc />
        public unsafe partial void CaptureSamples(Device* device, void* buffer, int sampleCount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, GetCaptureContextInteger param, int count,
            void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, GetCaptureContextInteger param, int count,
            int* data);

        /// <inheritdoc cref="CaptureOpenDevice" />
        public unsafe Device* CaptureOpenDevice<TBufferFormat>
        (
            string deviceName,
            uint frequency,
            TBufferFormat format,
            int size
        )
            where TBufferFormat : struct, Enum
        {
            return CaptureOpenDevice(deviceName, frequency, (BufferFormat) (object) format, size);
        }

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <typeparam name="TManagedFormat">The managed format of the buffer.</typeparam>
        /// <typeparam name="TBufferFormat">The format of the native buffer.</typeparam>
        /// <param name="device">The device.</param>
        /// <param name="bufferFormat">The data format of the buffer.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        /// <returns>The captured samples.</returns>
        public unsafe TManagedFormat[] CaptureSamples<TManagedFormat, TBufferFormat>
        (
            Device* device,
            TBufferFormat bufferFormat,
            int sampleCount
        )
            where TBufferFormat : struct, Enum
            where TManagedFormat : unmanaged
        {
            var formatSize = FormatHelpers.GetFormatSize(bufferFormat);

            var managedFormatSize = sizeof(TManagedFormat);
            var internalBufferSize = sampleCount * formatSize;
            var managedBufferElementCount = internalBufferSize / managedFormatSize;

            var resizeBuffer = new TManagedFormat[managedBufferElementCount];
            CaptureSamples(device, bufferFormat, sampleCount, in resizeBuffer);

            return resizeBuffer;
        }

        /// <summary>
        /// Completes a capture operation. This call does not block.
        /// </summary>
        /// <typeparam name="TManagedFormat">The managed format of the buffer.</typeparam>
        /// <typeparam name="TBufferFormat">The format of the native buffer.</typeparam>
        /// <param name="device">The device.</param>
        /// <param name="bufferFormat">The data format of the buffer.</param>
        /// <param name="sampleCount">The number of samples to retrieve.</param>
        /// <param name="buffer">The buffer to fill. </param>
        public unsafe void CaptureSamples<TManagedFormat, TBufferFormat>
        (
            Device* device,
            TBufferFormat bufferFormat,
            int sampleCount,
            in TManagedFormat[] buffer
        )
            where TBufferFormat : struct, Enum
            where TManagedFormat : unmanaged
        {
            var formatSize = FormatHelpers.GetFormatSize(bufferFormat);

            var managedFormatSize = sizeof(TManagedFormat);
            var internalBufferSize = sampleCount * formatSize;
            var managedBufferElementCount = internalBufferSize / managedFormatSize;

            if (buffer.Length < managedBufferElementCount)
            {
                throw new ArgumentException
                (
                    "The buffer wasn't large enough to contain all of the requested samples.",
                    nameof(buffer)
                );
            }

            fixed (void* ptr = buffer)
            {
                CaptureSamples(device, ptr, sampleCount);
            }
        }

        /// <summary>
        /// Creates a capture for the given device, using the specified settings.
        /// </summary>
        /// <typeparam name="TBufferFormat">The format of the native buffer.</typeparam>
        /// <param name="deviceName">The name of the device.</param>
        /// <param name="frequency">The capture frequency.</param>
        /// <param name="sampleFormat">The capture sample format.</param>
        /// <param name="bufferSize">The size of the ring buffer.</param>
        /// <returns>An object wrapping a capture capability.</returns>
        public AudioCapture<TBufferFormat> CreateCapture<TBufferFormat>
        (
            string deviceName = null,
            uint frequency = 22050,
            TBufferFormat? sampleFormat = null,
            int bufferSize = 4096
        )
            where TBufferFormat : struct, Enum
        {
            return new AudioCapture<TBufferFormat>(this, deviceName, frequency, sampleFormat, bufferSize);
        }

        /// <inheritdoc cref="GetContextProperty" />
        public unsafe int GetAvailableSamples(Device* device)
        {
            var result = 0;
            GetContextProperty(device, GetCaptureContextInteger.CaptureSamples, 1, &result);

            return result;
        }
    }
}