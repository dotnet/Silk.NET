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
        [NativeName("Src", "Line 2439, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterPropertiesFreeMembers")]
        public partial void AdapterPropertiesFreeMembers(AdapterProperties value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterPropertiesMemoryHeapsFreeMembers")]
        public partial void AdapterPropertiesMemoryHeapsFreeMembers(AdapterPropertiesMemoryHeaps value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDrmFormatCapabilitiesFreeMembers")]
        public partial void DrmFormatCapabilitiesFreeMembers(DrmFormatCapabilities value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2443, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public unsafe partial Silk.NET.Core.Bool32 GetInstanceFeatures(InstanceFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2443, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public partial Silk.NET.Core.Bool32 GetInstanceFeatures(ref InstanceFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2445, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccessStateFreeMembers")]
        public partial void SharedBufferMemoryEndAccessStateFreeMembers(SharedBufferMemoryEndAccessState value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2446, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccessStateFreeMembers")]
        public partial void SharedTextureMemoryEndAccessStateFreeMembers(SharedTextureMemoryEndAccessState value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2449, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2451, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFormatCapabilities")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterGetFormatCapabilities(Adapter* adapter, TextureFormat format, FormatCapabilities* capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2451, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFormatCapabilities")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterGetFormatCapabilities(Adapter* adapter, TextureFormat format, ref FormatCapabilities capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2452, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetInstance")]
        public unsafe partial Instance* AdapterGetInstance(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2457, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDeviceF")]
        public unsafe partial Future AdapterRequestDeviceF(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* options, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2457, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDeviceF")]
        public unsafe partial Future AdapterRequestDeviceF(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceDescriptor options, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2478, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2478, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2479, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsyncF")]
        public unsafe partial Future BufferMapAsyncF(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, BufferMapCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2499, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2499, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2499, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2505, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2505, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2505, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2520, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2536, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2536, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2536, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2536, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2537, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsyncF")]
        public unsafe partial Future DeviceCreateComputePipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2537, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsyncF")]
        public unsafe partial Future DeviceCreateComputePipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineDescriptor descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2538, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2538, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2539, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2541, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2541, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2548, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsyncF")]
        public unsafe partial Future DeviceCreateRenderPipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2548, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsyncF")]
        public unsafe partial Future DeviceCreateRenderPipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderPipelineDescriptor descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2551, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2551, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2556, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2559, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetSupportedSurfaceUsage")]
        public unsafe partial Silk.NET.WebGPU.TextureUsage DeviceGetSupportedSurfaceUsage(Device* device, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2561, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedBufferMemory")]
        public unsafe partial SharedBufferMemoryImpl* DeviceImportSharedBufferMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedBufferMemoryDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2561, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedBufferMemory")]
        public unsafe partial SharedBufferMemoryImpl* DeviceImportSharedBufferMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedBufferMemoryDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedFenceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedFenceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2563, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2563, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedTextureMemoryDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2564, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2564, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2564, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2566, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScopeF")]
        public unsafe partial Future DevicePopErrorScopeF(Device* device, PopErrorScopeCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2570, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(Device* device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2570, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback<T0>(Device* device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2572, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public unsafe partial void DeviceTick(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2573, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2573, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2578, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public unsafe partial void ExternalTextureDestroy(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2579, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureExpire")]
        public unsafe partial void ExternalTextureExpire(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2580, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRefresh")]
        public unsafe partial void ExternalTextureRefresh(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2581, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2581, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2581, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public unsafe partial void ExternalTextureReference(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2583, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2587, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateWGSLLanguageFeatures")]
        public unsafe partial nuint InstanceEnumerateWGSLLanguageFeatures(Instance* instance, WGSLFeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2587, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateWGSLLanguageFeatures")]
        public unsafe partial nuint InstanceEnumerateWGSLLanguageFeatures(Instance* instance, ref WGSLFeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2591, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapterF")]
        public unsafe partial Future InstanceRequestAdapterF(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2591, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapterF")]
        public unsafe partial Future InstanceRequestAdapterF(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RequestAdapterOptions options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2592, Column 28 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, FutureWaitInfo* futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2592, Column 28 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceWaitAny")]
        public unsafe partial WaitStatus InstanceWaitAny(Instance* instance, nuint futureCount, ref FutureWaitInfo futures, ulong timeoutNS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2610, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2613, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDoneF")]
        public unsafe partial Future QueueOnSubmittedWorkDoneF(Queue* queue, QueueWorkDoneCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPixelLocalStorageBarrier")]
        public unsafe partial void RenderPassEncoderPixelLocalStorageBarrier(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2681, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2681, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfoF")]
        public unsafe partial Future ShaderModuleGetCompilationInfoF(ShaderModule* shaderModule, CompilationInfoCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryBeginAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedBufferMemoryBeginAccessDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryBeginAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedBufferMemoryBeginAccessDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2689, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryCreateBuffer")]
        public unsafe partial Buffer* SharedBufferMemoryCreateBuffer(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2689, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryCreateBuffer")]
        public unsafe partial Buffer* SharedBufferMemoryCreateBuffer(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2690, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryEndAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, SharedBufferMemoryEndAccessState* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2690, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryEndAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, ref SharedBufferMemoryEndAccessState descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2691, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryGetProperties")]
        public unsafe partial void SharedBufferMemoryGetProperties(SharedBufferMemoryImpl* sharedBufferMemory, SharedBufferMemoryProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2691, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryGetProperties")]
        public unsafe partial void SharedBufferMemoryGetProperties(SharedBufferMemoryImpl* sharedBufferMemory, ref SharedBufferMemoryProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2692, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryIsDeviceLost")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryIsDeviceLost(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2694, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryReference")]
        public unsafe partial void SharedBufferMemoryReference(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2695, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryRelease")]
        public unsafe partial void SharedBufferMemoryRelease(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2698, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, SharedFenceExportInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2698, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, ref SharedFenceExportInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2699, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceReference")]
        public unsafe partial void SharedFenceReference(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2700, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceRelease")]
        public unsafe partial void SharedFenceRelease(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryBeginAccessDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SharedTextureMemoryBeginAccessDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2705, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, SharedTextureMemoryEndAccessState* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2705, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, ref SharedTextureMemoryEndAccessState descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2706, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial void SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, SharedTextureMemoryProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2706, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial void SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, ref SharedTextureMemoryProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2707, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryIsDeviceLost")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryIsDeviceLost(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2709, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryReference")]
        public unsafe partial void SharedTextureMemoryReference(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2710, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryRelease")]
        public unsafe partial void SharedTextureMemoryRelease(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2718, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTexture")]
        public unsafe partial Texture* SwapChainGetCurrentTexture(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2719, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2720, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public unsafe partial void SwapChainReference(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2722, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public unsafe partial void SwapChainRelease(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2725, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateErrorView")]
        public unsafe partial TextureView* TextureCreateErrorView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2725, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateErrorView")]
        public unsafe partial TextureView* TextureCreateErrorView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureViewDescriptor descriptor);

        public Dawn(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

