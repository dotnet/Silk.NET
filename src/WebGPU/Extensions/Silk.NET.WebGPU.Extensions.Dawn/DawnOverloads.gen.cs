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
        [NativeName("Src", "Line 2443, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 GetInstanceFeatures(this Dawn thisApi, Span<InstanceFeatures> features)
        {
            // SpanOverloader
            return thisApi.GetInstanceFeatures(ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(adapter, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2451, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterGetFormatCapabilities(this Dawn thisApi, Adapter* adapter, TextureFormat format, Span<FormatCapabilities> capabilities)
        {
            // SpanOverloader
            return thisApi.AdapterGetFormatCapabilities(adapter, format, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2457, Column 24 in dawn-webgpu.h")]
        public static unsafe Future AdapterRequestDeviceF(this Dawn thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> options, RequestDeviceCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.AdapterRequestDeviceF(adapter, in options.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2499, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(commandEncoder, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2505, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2537, Column 24 in dawn-webgpu.h")]
        public static unsafe Future DeviceCreateComputePipelineAsyncF(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipelineAsyncF(device, in descriptor.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2538, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateErrorBuffer(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, descriptor, in errorMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), in errorMessage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateErrorShaderModule(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorShaderModule(device, in descriptor.GetPinnableReference(), errorMessage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2541, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(device, in externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2548, Column 24 in dawn-webgpu.h")]
        public static unsafe Future DeviceCreateRenderPipelineAsyncF(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipelineAsyncF(device, in descriptor.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2551, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2561, Column 36 in dawn-webgpu.h")]
        public static unsafe SharedBufferMemoryImpl* DeviceImportSharedBufferMemory(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedBufferMemoryDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceImportSharedBufferMemory(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 29 in dawn-webgpu.h")]
        public static unsafe SharedFenceImpl* DeviceImportSharedFence(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedFenceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceImportSharedFence(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2563, Column 37 in dawn-webgpu.h")]
        public static unsafe SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedTextureMemoryDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceImportSharedTextureMemory(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2564, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this Dawn thisApi, Device* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2570, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Device* device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2573, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceValidateTextureDescriptor(this Dawn thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            thisApi.DeviceValidateTextureDescriptor(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2581, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(externalTexture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2587, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint InstanceEnumerateWGSLLanguageFeatures(this Dawn thisApi, Instance* instance, Span<WGSLFeatureName> features)
        {
            // SpanOverloader
            return thisApi.InstanceEnumerateWGSLLanguageFeatures(instance, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2591, Column 24 in dawn-webgpu.h")]
        public static unsafe Future InstanceRequestAdapterF(this Dawn thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, RequestAdapterCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.InstanceRequestAdapterF(instance, in options.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2592, Column 28 in dawn-webgpu.h")]
        public static unsafe WaitStatus InstanceWaitAny(this Dawn thisApi, Instance* instance, nuint futureCount, Span<FutureWaitInfo> futures, ulong timeoutNS)
        {
            // SpanOverloader
            return thisApi.InstanceWaitAny(instance, futureCount, ref futures.GetPinnableReference(), timeoutNS);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedBufferMemoryBeginAccess(this Dawn thisApi, SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedBufferMemoryBeginAccessDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedBufferMemoryBeginAccess(sharedBufferMemory, buffer, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2689, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* SharedBufferMemoryCreateBuffer(this Dawn thisApi, SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedBufferMemoryCreateBuffer(sharedBufferMemory, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2690, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedBufferMemoryEndAccess(this Dawn thisApi, SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, Span<SharedBufferMemoryEndAccessState> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedBufferMemoryEndAccess(sharedBufferMemory, buffer, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2691, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedBufferMemoryGetProperties(this Dawn thisApi, SharedBufferMemoryImpl* sharedBufferMemory, Span<SharedBufferMemoryProperties> properties)
        {
            // SpanOverloader
            thisApi.SharedBufferMemoryGetProperties(sharedBufferMemory, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedBufferMemorySetLabel(this Dawn thisApi, SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SharedBufferMemorySetLabel(sharedBufferMemory, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2698, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedFenceExportInfo(this Dawn thisApi, SharedFenceImpl* sharedFence, Span<SharedFenceExportInfo> info)
        {
            // SpanOverloader
            thisApi.SharedFenceExportInfo(sharedFence, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedTextureMemoryBeginAccessDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryBeginAccess(sharedTextureMemory, texture, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2704, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* SharedTextureMemoryCreateTexture(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryCreateTexture(sharedTextureMemory, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2705, Column 22 in dawn-webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, Span<SharedTextureMemoryEndAccessState> descriptor)
        {
            // SpanOverloader
            return thisApi.SharedTextureMemoryEndAccess(sharedTextureMemory, texture, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2706, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedTextureMemoryGetProperties(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, Span<SharedTextureMemoryProperties> properties)
        {
            // SpanOverloader
            thisApi.SharedTextureMemoryGetProperties(sharedTextureMemory, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2708, Column 18 in dawn-webgpu.h")]
        public static unsafe void SharedTextureMemorySetLabel(this Dawn thisApi, SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SharedTextureMemorySetLabel(sharedTextureMemory, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2725, Column 29 in dawn-webgpu.h")]
        public static unsafe TextureView* TextureCreateErrorView(this Dawn thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateErrorView(texture, in descriptor.GetPinnableReference());
        }

    }
}

