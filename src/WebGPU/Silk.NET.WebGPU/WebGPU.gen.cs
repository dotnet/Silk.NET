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

namespace Silk.NET.WebGPU
{
    public unsafe partial class WebGPU : NativeAPI
    {
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "WGPU_ARRAY_LAYER_COUNT_UNDEFINED")]
        public const uint ArrayLayerCountUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "WGPU_COPY_STRIDE_UNDEFINED")]
        public const uint CopyStrideUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "WGPU_LIMIT_U32_UNDEFINED")]
        public const uint LimitU32Undefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_LIMIT_U64_UNDEFINED")]
        public const ulong LimitU64Undefined = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "WGPU_MIP_LEVEL_COUNT_UNDEFINED")]
        public const uint MipLevelCountUndefined = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_WHOLE_MAP_SIZE")]
        public const ulong WholeMapSize = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "WGPU_WHOLE_SIZE")]
        public const ulong WholeSize = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(Silk.NET.Core.Native.FlowDirection.In)] in InstanceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterGetLimits(Adapter* adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterGetLimits(Adapter* adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public unsafe partial Silk.NET.Core.Bool32 AdapterHasFeature(Adapter* adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(ref Adapter adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public partial void AdapterRequestDevice<T0>(ref Adapter adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public partial void AdapterRequestDevice<T0>(ref Adapter adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public unsafe partial void BufferDestroy(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMapState")]
        public unsafe partial BufferMapState BufferGetMapState(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public unsafe partial ulong BufferGetSize(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public unsafe partial BufferUsage BufferGetUsage(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public unsafe partial void BufferUnmap(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public unsafe partial void CommandEncoderPopDebugGroup(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1463, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1466, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroups(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public unsafe partial void ComputePassEncoderEnd(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public unsafe partial void ComputePassEncoderPopDebugGroup(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ComputePipeline* computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1498, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public unsafe partial void DeviceDestroy(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Silk.NET.Core.Bool32 DeviceGetLimits(Device* device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Silk.NET.Core.Bool32 DeviceGetLimits(Device* device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1501, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1502, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public unsafe partial Silk.NET.Core.Bool32 DeviceHasFeature(Device* device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePopErrorScope(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePopErrorScope<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public unsafe partial void DevicePushErrorScope(Device* device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public unsafe partial void InstanceProcessEvents(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(ref Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public partial void InstanceRequestAdapter<T0>(ref Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public partial void InstanceRequestAdapter<T0>(ref Instance instance, [Flow(FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public unsafe partial void QuerySetDestroy(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public unsafe partial uint QuerySetGetCount(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public unsafe partial QueryType QuerySetGetType(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, ref Buffer buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, ref Buffer buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(ref Queue queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, ref Buffer buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public partial void QueueWriteBuffer<T0>(ref Queue queue, ref Buffer buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public partial void QueueWriteBuffer<T0>(ref Queue queue, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public unsafe partial void RenderBundleEncoderDraw(RenderBundleEncoder* renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public unsafe partial void RenderBundleEncoderDrawIndexed(RenderBundleEncoder* renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public unsafe partial void RenderBundleEncoderPopDebugGroup(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public unsafe partial void RenderPassEncoderBeginOcclusionQuery(RenderPassEncoder* renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public unsafe partial void RenderPassEncoderDraw(RenderPassEncoder* renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public unsafe partial void RenderPassEncoderDrawIndexed(RenderPassEncoder* renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public unsafe partial void RenderPassEncoderEnd(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1553, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public unsafe partial void RenderPassEncoderEndOcclusionQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1554, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundleCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundleCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1557, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public unsafe partial void RenderPassEncoderPopDebugGroup(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1561, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1564, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public unsafe partial void RenderPassEncoderSetScissorRect(RenderPassEncoder* renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public unsafe partial void RenderPassEncoderSetStencilReference(RenderPassEncoder* renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1567, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public unsafe partial void RenderPassEncoderSetViewport(RenderPassEncoder* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(RenderPipeline* renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(Surface* surface, Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1584, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1585, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1589, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public unsafe partial void TextureDestroy(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public unsafe partial uint TextureGetDepthOrArrayLayers(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1591, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public unsafe partial TextureDimension TextureGetDimension(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1592, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public unsafe partial TextureFormat TextureGetFormat(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1593, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public unsafe partial uint TextureGetHeight(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1594, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public unsafe partial uint TextureGetMipLevelCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public unsafe partial uint TextureGetSampleCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1596, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public unsafe partial TextureUsage TextureGetUsage(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public unsafe partial uint TextureGetWidth(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);


        public WebGPU(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

