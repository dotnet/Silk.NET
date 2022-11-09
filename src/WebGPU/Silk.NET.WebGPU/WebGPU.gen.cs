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
        [NativeName("Src", "Line 1405, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(FlowDirection.In)] InstanceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1405, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance([Flow(FlowDirection.In)] in InstanceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(FlowDirection.In)] byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(FlowDirection.In)] in byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(ref Device device, [Flow(FlowDirection.In)] byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref Device device, [Flow(FlowDirection.In)] in byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref Device device, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(ref Adapter adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public partial nuint AdapterEnumerateFeatures(ref Adapter adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(Adapter* adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(Adapter* adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(ref Adapter adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public partial bool AdapterGetLimits(ref Adapter adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(ref Adapter adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public partial void AdapterGetProperties(ref Adapter adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1412, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public unsafe partial bool AdapterHasFeature(Adapter* adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1412, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public partial bool AdapterHasFeature(ref Adapter adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(ref Adapter adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public partial void AdapterRequestDevice<T0>(ref Adapter adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(ref BindGroup bindGroup, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroup bindGroup, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroup bindGroup, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1422, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public unsafe partial void BufferDestroy(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1422, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public partial void BufferDestroy(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(ref Buffer buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(ref Buffer buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public unsafe partial ulong BufferGetSize(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public partial ulong BufferGetSize(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public unsafe partial BufferUsage BufferGetUsage(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public partial BufferUsage BufferGetUsage(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(ref Buffer buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public partial void BufferMapAsync<T0>(ref Buffer buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(ref Buffer buffer, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref Buffer buffer, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref Buffer buffer, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1429, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public unsafe partial void BufferUnmap(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1429, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public partial void BufferUnmap(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public partial void CommandEncoderClearBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, ref Buffer source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, ref Buffer source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, Buffer* source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, ref Buffer source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, ref Buffer source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyBuffer* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyBuffer source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyBuffer* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyBuffer destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public unsafe partial void CommandEncoderPopDebugGroup(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public partial void CommandEncoderPopDebugGroup(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(ref CommandEncoder commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public partial void CommandEncoderWriteTimestamp(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ref ComputePassEncoder computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public partial void ComputePassEncoderBeginPipelineStatisticsQuery(ref ComputePassEncoder computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroups(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public partial void ComputePassEncoderDispatchWorkgroups(ref ComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoder computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoder computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public unsafe partial void ComputePassEncoderEnd(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public partial void ComputePassEncoderEnd(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public partial void ComputePassEncoderEndPipelineStatisticsQuery(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public unsafe partial void ComputePassEncoderPopDebugGroup(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public partial void ComputePassEncoderPopDebugGroup(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ref ComputePipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ref ComputePassEncoder computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public partial void ComputePassEncoderSetPipeline(ref ComputePassEncoder computePassEncoder, ref ComputePipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1464, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ComputePipeline* computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1464, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ref ComputePipeline computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(FlowDirection.In)] BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, [Flow(FlowDirection.In)] in BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(ref Device device, [Flow(FlowDirection.In)] BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(ref Device device, [Flow(FlowDirection.In)] in BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(FlowDirection.In)] BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, [Flow(FlowDirection.In)] in BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(ref Device device, [Flow(FlowDirection.In)] BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(ref Device device, [Flow(FlowDirection.In)] in BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, [Flow(FlowDirection.In)] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(ref Device device, [Flow(FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(ref Device device, [Flow(FlowDirection.In)] in BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(FlowDirection.In)] CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, [Flow(FlowDirection.In)] in CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(ref Device device, [Flow(FlowDirection.In)] CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(ref Device device, [Flow(FlowDirection.In)] in CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(ref Device device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(ref Device device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] in ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(FlowDirection.In)] PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, [Flow(FlowDirection.In)] in PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(ref Device device, [Flow(FlowDirection.In)] PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(ref Device device, [Flow(FlowDirection.In)] in PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(FlowDirection.In)] QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, [Flow(FlowDirection.In)] in QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(ref Device device, [Flow(FlowDirection.In)] QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(ref Device device, [Flow(FlowDirection.In)] in QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(FlowDirection.In)] RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, [Flow(FlowDirection.In)] in RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(ref Device device, [Flow(FlowDirection.In)] RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(ref Device device, [Flow(FlowDirection.In)] in RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(ref Device device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(ref Device device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, [Flow(FlowDirection.In)] in RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(FlowDirection.In)] SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, [Flow(FlowDirection.In)] in SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(ref Device device, [Flow(FlowDirection.In)] SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(ref Device device, [Flow(FlowDirection.In)] in SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(FlowDirection.In)] ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, [Flow(FlowDirection.In)] in ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(ref Device device, [Flow(FlowDirection.In)] ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(ref Device device, [Flow(FlowDirection.In)] in ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(FlowDirection.In)] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, ref Surface surface, [Flow(FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, ref Surface surface, [Flow(FlowDirection.In)] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, Surface* surface, [Flow(FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, Surface* surface, [Flow(FlowDirection.In)] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, ref Surface surface, [Flow(FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, ref Surface surface, [Flow(FlowDirection.In)] in SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, [Flow(FlowDirection.In)] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(ref Device device, [Flow(FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(ref Device device, [Flow(FlowDirection.In)] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public unsafe partial void DeviceDestroy(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public partial void DeviceDestroy(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(ref Device device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public partial nuint DeviceEnumerateFeatures(ref Device device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(Device* device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(Device* device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(ref Device device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public partial bool DeviceGetLimits(ref Device device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public unsafe partial bool DeviceHasFeature(Device* device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public partial bool DeviceHasFeature(ref Device device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(ref Device device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public partial bool DevicePopErrorScope<T0>(ref Device device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public unsafe partial void DevicePushErrorScope(Device* device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public partial void DevicePushErrorScope(ref Device device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(ref Device device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public partial void DeviceSetDeviceLostCallback<T0>(ref Device device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(ref Device device, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref Device device, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref Device device, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(ref Device device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public partial void DeviceSetUncapturedErrorCallback<T0>(ref Device device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(FlowDirection.In)] SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, [Flow(FlowDirection.In)] in SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(ref Instance instance, [Flow(FlowDirection.In)] SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(ref Instance instance, [Flow(FlowDirection.In)] in SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public unsafe partial void InstanceProcessEvents(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public partial void InstanceProcessEvents(ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, [Flow(FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(ref Instance instance, [Flow(FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, [Flow(FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public partial void InstanceRequestAdapter<T0>(ref Instance instance, [Flow(FlowDirection.In)] in RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public unsafe partial void QuerySetDestroy(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public partial void QuerySetDestroy(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public unsafe partial uint QuerySetGetCount(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public partial uint QuerySetGetCount(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public unsafe partial QueryType QuerySetGetType(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public partial QueryType QuerySetGetType(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(ref QuerySet querySet, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySet querySet, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySet querySet, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(ref Queue queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public partial void QueueOnSubmittedWorkDone<T0>(ref Queue queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(ref Queue queue, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref Queue queue, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref Queue queue, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref Queue queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref Queue queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(ref Queue queue, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public partial void QueueWriteBuffer<T0>(ref Queue queue, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] void* data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public partial void QueueWriteTexture<T0>(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in T0 data, nuint dataSize, [Flow(FlowDirection.In)] in TextureDataLayout dataLayout, [Flow(FlowDirection.In)] in Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1516, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public unsafe partial void RenderBundleEncoderDraw(RenderBundleEncoder* renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1516, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public partial void RenderBundleEncoderDraw(ref RenderBundleEncoder renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1517, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public unsafe partial void RenderBundleEncoderDrawIndexed(RenderBundleEncoder* renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1517, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public partial void RenderBundleEncoderDrawIndexed(ref RenderBundleEncoder renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoder renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoder renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoder renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoder renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] in RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] in RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public unsafe partial void RenderBundleEncoderPopDebugGroup(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public partial void RenderBundleEncoderPopDebugGroup(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoder renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoder renderBundleEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoder renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoder renderBundleEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoder renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoder renderBundleEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public unsafe partial void RenderPassEncoderBeginOcclusionQuery(RenderPassEncoder* renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public partial void RenderPassEncoderBeginOcclusionQuery(ref RenderPassEncoder renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(ref RenderPassEncoder renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public partial void RenderPassEncoderBeginPipelineStatisticsQuery(ref RenderPassEncoder renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public unsafe partial void RenderPassEncoderDraw(RenderPassEncoder* renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public partial void RenderPassEncoderDraw(ref RenderPassEncoder renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public unsafe partial void RenderPassEncoderDrawIndexed(RenderPassEncoder* renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public partial void RenderPassEncoderDrawIndexed(ref RenderPassEncoder renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoder renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoder renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoder renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoder renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public unsafe partial void RenderPassEncoderEnd(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public partial void RenderPassEncoderEnd(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public unsafe partial void RenderPassEncoderEndOcclusionQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public partial void RenderPassEncoderEndOcclusionQuery(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public partial void RenderPassEncoderEndPipelineStatisticsQuery(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundlesCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundlesCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoder renderPassEncoder, uint bundlesCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoder renderPassEncoder, uint bundlesCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] in byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public unsafe partial void RenderPassEncoderPopDebugGroup(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public partial void RenderPassEncoderPopDebugGroup(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] in byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, [Flow(FlowDirection.In)] in uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] in Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] in Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoder renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoder renderPassEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(ref RenderPassEncoder renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public partial void RenderPassEncoderSetPipeline(ref RenderPassEncoder renderPassEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public unsafe partial void RenderPassEncoderSetScissorRect(RenderPassEncoder* renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public partial void RenderPassEncoderSetScissorRect(ref RenderPassEncoder renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public unsafe partial void RenderPassEncoderSetStencilReference(RenderPassEncoder* renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public partial void RenderPassEncoderSetStencilReference(ref RenderPassEncoder renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoder renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoder renderPassEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public unsafe partial void RenderPassEncoderSetViewport(RenderPassEncoder* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public partial void RenderPassEncoderSetViewport(ref RenderPassEncoder renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(RenderPipeline* renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(ref RenderPipeline renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(ref Sampler sampler, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref Sampler sampler, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref Sampler sampler, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ref ShaderModule shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public partial void ShaderModuleGetCompilationInfo<T0>(ref ShaderModule shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(Surface* surface, Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(Surface* surface, ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(ref Surface surface, Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public partial TextureFormat SurfaceGetPreferredFormat(ref Surface surface, ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public partial void SwapChainPresent(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, [Flow(FlowDirection.In)] in TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(ref Texture texture, [Flow(FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(ref Texture texture, [Flow(FlowDirection.In)] in TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public unsafe partial void TextureDestroy(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public partial void TextureDestroy(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public unsafe partial uint TextureGetDepthOrArrayLayers(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public partial uint TextureGetDepthOrArrayLayers(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1576, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public unsafe partial TextureDimension TextureGetDimension(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1576, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public partial TextureDimension TextureGetDimension(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public unsafe partial TextureFormat TextureGetFormat(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public partial TextureFormat TextureGetFormat(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public unsafe partial uint TextureGetHeight(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public partial uint TextureGetHeight(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1579, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public unsafe partial uint TextureGetMipLevelCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1579, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public partial uint TextureGetMipLevelCount(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1580, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public unsafe partial uint TextureGetSampleCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1580, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public partial uint TextureGetSampleCount(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public unsafe partial TextureUsage TextureGetUsage(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public partial TextureUsage TextureGetUsage(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public unsafe partial uint TextureGetWidth(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public partial uint TextureGetWidth(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(ref Texture texture, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref Texture texture, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref Texture texture, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(ref TextureView textureView, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureView textureView, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureView textureView, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);


        public WebGPU(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

