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
using Silk.NET.WebGPU;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Extension("dawn-webgpu.h")]
    public unsafe partial class Dawn : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "dawn-webgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2174, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterPropertiesFreeMembers")]
        public partial void AdapterPropertiesFreeMembers(AdapterProperties value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2176, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public unsafe partial Silk.NET.Core.Bool32 GetInstanceFeatures(InstanceFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2176, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public partial Silk.NET.Core.Bool32 GetInstanceFeatures(ref InstanceFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2178, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccessStateFreeMembers")]
        public partial void SharedTextureMemoryEndAccessStateFreeMembers(SharedTextureMemoryEndAccessState value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2181, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2181, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2183, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetInstance")]
        public unsafe partial Instance* AdapterGetInstance(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2228, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2228, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2228, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2234, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2234, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2234, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2249, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2266, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2266, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2267, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2268, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2269, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2269, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2270, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2270, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2278, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2278, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2282, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2282, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2282, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2283, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetSupportedSurfaceUsage")]
        public unsafe partial Silk.NET.WebGPU.TextureUsage DeviceGetSupportedSurfaceUsage(Device* device, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2288, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedFenceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2288, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedFenceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2289, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2289, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedTextureMemoryDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2290, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2290, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2290, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2293, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2295, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(Device* device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2295, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback<T0>(Device* device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2297, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public unsafe partial void DeviceTick(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2303, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public unsafe partial void ExternalTextureDestroy(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2304, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureExpire")]
        public unsafe partial void ExternalTextureExpire(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2305, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRefresh")]
        public unsafe partial void ExternalTextureRefresh(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2306, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2306, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2306, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2307, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public unsafe partial void ExternalTextureReference(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2308, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 28 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, FutureWaitInfo* futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 28 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, ref FutureWaitInfo futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2332, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2333, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2334, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, ulong signalValue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2334, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, ulong signalValue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2335, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDoneF")]
        public unsafe partial Future QueueOnSubmittedWorkDoneF(Queue* queue, QueueWorkDoneCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2375, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPixelLocalStorageBarrier")]
        public unsafe partial void RenderPassEncoderPixelLocalStorageBarrier(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2387, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, SharedFenceExportInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, ref SharedFenceExportInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2410, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceReference")]
        public unsafe partial void SharedFenceReference(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2411, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceRelease")]
        public unsafe partial void SharedFenceRelease(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2414, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryBeginAccessDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2414, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedTextureMemoryBeginAccessDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, SharedTextureMemoryEndAccessState* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, ref SharedTextureMemoryEndAccessState descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2417, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial void SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, SharedTextureMemoryProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2417, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial void SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, ref SharedTextureMemoryProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2418, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2418, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2418, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2419, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryReference")]
        public unsafe partial void SharedTextureMemoryReference(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2420, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryRelease")]
        public unsafe partial void SharedTextureMemoryRelease(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2427, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTexture")]
        public unsafe partial Texture* SwapChainGetCurrentTexture(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2428, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2429, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2430, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public unsafe partial void SwapChainReference(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2431, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public unsafe partial void SwapChainRelease(SwapChain* swapChain);

        public Dawn(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

