// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    public static class DawnOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Adapter* adapter, [Flow(FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(adapter, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(commandEncoder, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1743, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateErrorBuffer(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(device, in externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1758, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Device* device, DeviceLostReason type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Device* device, ErrorType type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Device* device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceValidateTextureDescriptor(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            thisApi.DeviceValidateTextureDescriptor(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1779, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, ExternalTextureImpl* externalTexture, [Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(externalTexture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

    }
}

