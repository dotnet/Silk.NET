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
        [NativeName("Src", "Line 2176, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 GetInstanceFeatures(this Dawn thisApi, Span<InstanceFeatures> features)
        {
            // SpanOverloader
            return thisApi.GetInstanceFeatures(ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2181, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(adapter, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2228, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(commandEncoder, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2234, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2266, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateErrorBuffer(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, descriptor, in errorMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), in errorMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2269, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2270, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(device, in externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2278, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2282, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2288, Column 29 in dawn-webgpu.h")]
        public static unsafe SharedFenceImpl* DeviceImportSharedFence(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedFenceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceImportSharedFence(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2289, Column 37 in dawn-webgpu.h")]
        public static unsafe SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedTextureMemoryDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceImportSharedTextureMemory(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2290, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this Dawn thisApi, Device* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2295, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Device* device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceValidateTextureDescriptor(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            thisApi.DeviceValidateTextureDescriptor(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2306, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(externalTexture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 28 in dawn-webgpu.h")]
        public static unsafe WaitStatus InstanceWaitAny(this Dawn thisApi, Instance* instance, nuint futureCount, Span<FutureWaitInfo> futures, ulong timeoutNS)
        {
            // SpanOverloader
            return thisApi.InstanceWaitAny(instance, futureCount, ref futures.GetPinnableReference(), timeoutNS);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedFenceExportInfo(this Dawn thisApi, SharedFenceImpl* sharedFence, Span<SharedFenceExportInfo> info)
        {
            // SpanOverloader
            thisApi.SharedFenceExportInfo(sharedFence, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2414, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedTextureMemoryBeginAccessDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryBeginAccess(sharedTextureMemory, texture, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* SharedTextureMemoryCreateTexture(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryCreateTexture(sharedTextureMemory, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, Span<SharedTextureMemoryEndAccessState> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryEndAccess(sharedTextureMemory, texture, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2417, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedTextureMemoryGetProperties(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Span<SharedTextureMemoryProperties> properties)
        {
            // SpanOverloader
            thisApi.SharedTextureMemoryGetProperties(sharedTextureMemory, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2418, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedTextureMemorySetLabel(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SharedTextureMemorySetLabel(sharedTextureMemory, in label.GetPinnableReference());
        }

    }
}

