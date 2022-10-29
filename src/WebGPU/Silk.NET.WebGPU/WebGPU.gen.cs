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
        public unsafe partial InstanceImpl* CreateInstance(InstanceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1405, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial InstanceImpl* CreateInstance(ref InstanceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(DeviceImpl* device, byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(DeviceImpl* device, ref byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(DeviceImpl* device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(ref DeviceImpl device, byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref DeviceImpl device, ref byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref DeviceImpl device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(AdapterImpl* adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(AdapterImpl* adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(ref AdapterImpl adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public partial nuint AdapterEnumerateFeatures(ref AdapterImpl adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(AdapterImpl* adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(AdapterImpl* adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(ref AdapterImpl adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public partial bool AdapterGetLimits(ref AdapterImpl adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(AdapterImpl* adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(AdapterImpl* adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(ref AdapterImpl adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public partial void AdapterGetProperties(ref AdapterImpl adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1412, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public unsafe partial bool AdapterHasFeature(AdapterImpl* adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1412, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public partial bool AdapterHasFeature(ref AdapterImpl adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(AdapterImpl* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(AdapterImpl* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(AdapterImpl* adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(AdapterImpl* adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref AdapterImpl adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(ref AdapterImpl adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref AdapterImpl adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public partial void AdapterRequestDevice<T0>(ref AdapterImpl adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroupImpl* bindGroup, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroupImpl* bindGroup, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroupImpl* bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(ref BindGroupImpl bindGroup, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroupImpl bindGroup, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroupImpl bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayoutImpl* bindGroupLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayoutImpl* bindGroupLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayoutImpl* bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(ref BindGroupLayoutImpl bindGroupLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayoutImpl bindGroupLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayoutImpl bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1422, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public unsafe partial void BufferDestroy(BufferImpl* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1422, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public partial void BufferDestroy(ref BufferImpl buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(BufferImpl* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(ref BufferImpl buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(BufferImpl* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(ref BufferImpl buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public unsafe partial ulong BufferGetSize(BufferImpl* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public partial ulong BufferGetSize(ref BufferImpl buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public unsafe partial BufferUsage BufferGetUsage(BufferImpl* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public partial BufferUsage BufferGetUsage(ref BufferImpl buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(BufferImpl* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(BufferImpl* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(ref BufferImpl buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public partial void BufferMapAsync<T0>(ref BufferImpl buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(BufferImpl* buffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(BufferImpl* buffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(BufferImpl* buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(ref BufferImpl buffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref BufferImpl buffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref BufferImpl buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1429, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public unsafe partial void BufferUnmap(BufferImpl* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1429, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public partial void BufferUnmap(ref BufferImpl buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBufferImpl* commandBuffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBufferImpl* commandBuffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBufferImpl* commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(ref CommandBufferImpl commandBuffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBufferImpl commandBuffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBufferImpl commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoderImpl* CommandEncoderBeginComputePass(CommandEncoderImpl* commandEncoder, ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoderImpl* CommandEncoderBeginComputePass(CommandEncoderImpl* commandEncoder, ref ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoderImpl* CommandEncoderBeginComputePass(ref CommandEncoderImpl commandEncoder, ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoderImpl* CommandEncoderBeginComputePass(ref CommandEncoderImpl commandEncoder, ref ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoderImpl* CommandEncoderBeginRenderPass(CommandEncoderImpl* commandEncoder, RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoderImpl* CommandEncoderBeginRenderPass(CommandEncoderImpl* commandEncoder, ref RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoderImpl* CommandEncoderBeginRenderPass(ref CommandEncoderImpl commandEncoder, RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoderImpl* CommandEncoderBeginRenderPass(ref CommandEncoderImpl commandEncoder, ref RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoderImpl* commandEncoder, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoderImpl* commandEncoder, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(ref CommandEncoderImpl commandEncoder, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public partial void CommandEncoderClearBuffer(ref CommandEncoderImpl commandEncoder, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoderImpl* commandEncoder, BufferImpl* source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoderImpl* commandEncoder, BufferImpl* source, ulong sourceOffset, ref BufferImpl destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoderImpl* commandEncoder, ref BufferImpl source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoderImpl* commandEncoder, ref BufferImpl source, ulong sourceOffset, ref BufferImpl destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoderImpl commandEncoder, BufferImpl* source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoderImpl commandEncoder, BufferImpl* source, ulong sourceOffset, ref BufferImpl destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoderImpl commandEncoder, ref BufferImpl source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoderImpl commandEncoder, ref BufferImpl source, ulong sourceOffset, ref BufferImpl destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public partial void CommandEncoderCopyBufferToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoderImpl* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public partial void CommandEncoderCopyTextureToTexture(ref CommandEncoderImpl commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBufferImpl* CommandEncoderFinish(CommandEncoderImpl* commandEncoder, CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBufferImpl* CommandEncoderFinish(CommandEncoderImpl* commandEncoder, ref CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBufferImpl* CommandEncoderFinish(ref CommandEncoderImpl commandEncoder, CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBufferImpl* CommandEncoderFinish(ref CommandEncoderImpl commandEncoder, ref CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoderImpl* commandEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoderImpl* commandEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoderImpl* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(ref CommandEncoderImpl commandEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoderImpl commandEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoderImpl commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public unsafe partial void CommandEncoderPopDebugGroup(CommandEncoderImpl* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public partial void CommandEncoderPopDebugGroup(ref CommandEncoderImpl commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoderImpl* commandEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoderImpl* commandEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoderImpl* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(ref CommandEncoderImpl commandEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoderImpl commandEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoderImpl commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoderImpl* commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoderImpl* commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, ref BufferImpl destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoderImpl* commandEncoder, ref QuerySetImpl querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoderImpl* commandEncoder, ref QuerySetImpl querySet, uint firstQuery, uint queryCount, ref BufferImpl destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoderImpl commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoderImpl commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, ref BufferImpl destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoderImpl commandEncoder, ref QuerySetImpl querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public partial void CommandEncoderResolveQuerySet(ref CommandEncoderImpl commandEncoder, ref QuerySetImpl querySet, uint firstQuery, uint queryCount, ref BufferImpl destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoderImpl* commandEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoderImpl* commandEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoderImpl* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(ref CommandEncoderImpl commandEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoderImpl commandEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoderImpl commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoderImpl* commandEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoderImpl* commandEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(ref CommandEncoderImpl commandEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public partial void CommandEncoderWriteTimestamp(ref CommandEncoderImpl commandEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoderImpl* computePassEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoderImpl* computePassEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ref ComputePassEncoderImpl computePassEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public partial void ComputePassEncoderBeginPipelineStatisticsQuery(ref ComputePassEncoderImpl computePassEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroups(ComputePassEncoderImpl* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public partial void ComputePassEncoderDispatchWorkgroups(ref ComputePassEncoderImpl computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoderImpl* computePassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoderImpl* computePassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoderImpl computePassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoderImpl computePassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public unsafe partial void ComputePassEncoderEnd(ComputePassEncoderImpl* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public partial void ComputePassEncoderEnd(ref ComputePassEncoderImpl computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoderImpl* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public partial void ComputePassEncoderEndPipelineStatisticsQuery(ref ComputePassEncoderImpl computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoderImpl* computePassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoderImpl* computePassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoderImpl* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoderImpl computePassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoderImpl computePassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoderImpl computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public unsafe partial void ComputePassEncoderPopDebugGroup(ComputePassEncoderImpl* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public partial void ComputePassEncoderPopDebugGroup(ref ComputePassEncoderImpl computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoderImpl* computePassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoderImpl* computePassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoderImpl* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoderImpl computePassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoderImpl computePassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoderImpl computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoderImpl* computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoderImpl* computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoderImpl* computePassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoderImpl* computePassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoderImpl computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoderImpl computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoderImpl computePassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoderImpl computePassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoderImpl* computePassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoderImpl* computePassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoderImpl* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ref ComputePassEncoderImpl computePassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoderImpl computePassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoderImpl computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoderImpl* computePassEncoder, ComputePipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoderImpl* computePassEncoder, ref ComputePipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ref ComputePassEncoderImpl computePassEncoder, ComputePipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public partial void ComputePassEncoderSetPipeline(ref ComputePassEncoderImpl computePassEncoder, ref ComputePipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1464, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* ComputePipelineGetBindGroupLayout(ComputePipelineImpl* computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1464, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* ComputePipelineGetBindGroupLayout(ref ComputePipelineImpl computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipelineImpl* computePipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipelineImpl* computePipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipelineImpl* computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ref ComputePipelineImpl computePipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipelineImpl computePipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipelineImpl computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroupImpl* DeviceCreateBindGroup(DeviceImpl* device, BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroupImpl* DeviceCreateBindGroup(DeviceImpl* device, ref BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroupImpl* DeviceCreateBindGroup(ref DeviceImpl device, BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroupImpl* DeviceCreateBindGroup(ref DeviceImpl device, ref BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* DeviceCreateBindGroupLayout(DeviceImpl* device, BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* DeviceCreateBindGroupLayout(DeviceImpl* device, ref BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* DeviceCreateBindGroupLayout(ref DeviceImpl device, BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* DeviceCreateBindGroupLayout(ref DeviceImpl device, ref BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial BufferImpl* DeviceCreateBuffer(DeviceImpl* device, BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial BufferImpl* DeviceCreateBuffer(DeviceImpl* device, ref BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial BufferImpl* DeviceCreateBuffer(ref DeviceImpl device, BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial BufferImpl* DeviceCreateBuffer(ref DeviceImpl device, ref BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoderImpl* DeviceCreateCommandEncoder(DeviceImpl* device, CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoderImpl* DeviceCreateCommandEncoder(DeviceImpl* device, ref CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoderImpl* DeviceCreateCommandEncoder(ref DeviceImpl device, CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoderImpl* DeviceCreateCommandEncoder(ref DeviceImpl device, ref CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipelineImpl* DeviceCreateComputePipeline(DeviceImpl* device, ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipelineImpl* DeviceCreateComputePipeline(DeviceImpl* device, ref ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipelineImpl* DeviceCreateComputePipeline(ref DeviceImpl device, ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipelineImpl* DeviceCreateComputePipeline(ref DeviceImpl device, ref ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(DeviceImpl* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(DeviceImpl* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(DeviceImpl* device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(DeviceImpl* device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref DeviceImpl device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(ref DeviceImpl device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref DeviceImpl device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public partial void DeviceCreateComputePipelineAsync<T0>(ref DeviceImpl device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayoutImpl* DeviceCreatePipelineLayout(DeviceImpl* device, PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayoutImpl* DeviceCreatePipelineLayout(DeviceImpl* device, ref PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayoutImpl* DeviceCreatePipelineLayout(ref DeviceImpl device, PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayoutImpl* DeviceCreatePipelineLayout(ref DeviceImpl device, ref PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySetImpl* DeviceCreateQuerySet(DeviceImpl* device, QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySetImpl* DeviceCreateQuerySet(DeviceImpl* device, ref QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySetImpl* DeviceCreateQuerySet(ref DeviceImpl device, QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySetImpl* DeviceCreateQuerySet(ref DeviceImpl device, ref QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(DeviceImpl* device, RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(DeviceImpl* device, ref RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(ref DeviceImpl device, RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(ref DeviceImpl device, ref RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipelineImpl* DeviceCreateRenderPipeline(DeviceImpl* device, RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipelineImpl* DeviceCreateRenderPipeline(DeviceImpl* device, ref RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipelineImpl* DeviceCreateRenderPipeline(ref DeviceImpl device, RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipelineImpl* DeviceCreateRenderPipeline(ref DeviceImpl device, ref RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(DeviceImpl* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(DeviceImpl* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(DeviceImpl* device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(DeviceImpl* device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref DeviceImpl device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(ref DeviceImpl device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref DeviceImpl device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public partial void DeviceCreateRenderPipelineAsync<T0>(ref DeviceImpl device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial SamplerImpl* DeviceCreateSampler(DeviceImpl* device, SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial SamplerImpl* DeviceCreateSampler(DeviceImpl* device, ref SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial SamplerImpl* DeviceCreateSampler(ref DeviceImpl device, SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial SamplerImpl* DeviceCreateSampler(ref DeviceImpl device, ref SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModuleImpl* DeviceCreateShaderModule(DeviceImpl* device, ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModuleImpl* DeviceCreateShaderModule(DeviceImpl* device, ref ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModuleImpl* DeviceCreateShaderModule(ref DeviceImpl device, ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModuleImpl* DeviceCreateShaderModule(ref DeviceImpl device, ref ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(DeviceImpl* device, SurfaceImpl* surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(DeviceImpl* device, SurfaceImpl* surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(DeviceImpl* device, ref SurfaceImpl surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(DeviceImpl* device, ref SurfaceImpl surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(ref DeviceImpl device, SurfaceImpl* surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(ref DeviceImpl device, SurfaceImpl* surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(ref DeviceImpl device, ref SurfaceImpl surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChainImpl* DeviceCreateSwapChain(ref DeviceImpl device, ref SurfaceImpl surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial TextureImpl* DeviceCreateTexture(DeviceImpl* device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial TextureImpl* DeviceCreateTexture(DeviceImpl* device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial TextureImpl* DeviceCreateTexture(ref DeviceImpl device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial TextureImpl* DeviceCreateTexture(ref DeviceImpl device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public unsafe partial void DeviceDestroy(DeviceImpl* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public partial void DeviceDestroy(ref DeviceImpl device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(DeviceImpl* device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(DeviceImpl* device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(ref DeviceImpl device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public partial nuint DeviceEnumerateFeatures(ref DeviceImpl device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(DeviceImpl* device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(DeviceImpl* device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(ref DeviceImpl device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public partial bool DeviceGetLimits(ref DeviceImpl device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial QueueImpl* DeviceGetQueue(DeviceImpl* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 23 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial QueueImpl* DeviceGetQueue(ref DeviceImpl device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public unsafe partial bool DeviceHasFeature(DeviceImpl* device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public partial bool DeviceHasFeature(ref DeviceImpl device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(DeviceImpl* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope<T0>(DeviceImpl* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(ref DeviceImpl device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public partial bool DevicePopErrorScope<T0>(ref DeviceImpl device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public unsafe partial void DevicePushErrorScope(DeviceImpl* device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public partial void DevicePushErrorScope(ref DeviceImpl device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(DeviceImpl* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(DeviceImpl* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(ref DeviceImpl device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public partial void DeviceSetDeviceLostCallback<T0>(ref DeviceImpl device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(DeviceImpl* device, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(DeviceImpl* device, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(DeviceImpl* device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(ref DeviceImpl device, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref DeviceImpl device, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref DeviceImpl device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(DeviceImpl* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback<T0>(DeviceImpl* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(ref DeviceImpl device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public partial void DeviceSetUncapturedErrorCallback<T0>(ref DeviceImpl device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial SurfaceImpl* InstanceCreateSurface(InstanceImpl* instance, SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial SurfaceImpl* InstanceCreateSurface(InstanceImpl* instance, ref SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial SurfaceImpl* InstanceCreateSurface(ref InstanceImpl instance, SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial SurfaceImpl* InstanceCreateSurface(ref InstanceImpl instance, ref SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public unsafe partial void InstanceProcessEvents(InstanceImpl* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceProcessEvents")]
        public partial void InstanceProcessEvents(ref InstanceImpl instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(InstanceImpl* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(InstanceImpl* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(InstanceImpl* instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(InstanceImpl* instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref InstanceImpl instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(ref InstanceImpl instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref InstanceImpl instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public partial void InstanceRequestAdapter<T0>(ref InstanceImpl instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayoutImpl* pipelineLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayoutImpl* pipelineLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayoutImpl* pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(ref PipelineLayoutImpl pipelineLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayoutImpl pipelineLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayoutImpl pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public unsafe partial void QuerySetDestroy(QuerySetImpl* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public partial void QuerySetDestroy(ref QuerySetImpl querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public unsafe partial uint QuerySetGetCount(QuerySetImpl* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public partial uint QuerySetGetCount(ref QuerySetImpl querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public unsafe partial QueryType QuerySetGetType(QuerySetImpl* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 27 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public partial QueryType QuerySetGetType(ref QuerySetImpl querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySetImpl* querySet, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySetImpl* querySet, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySetImpl* querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(ref QuerySetImpl querySet, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySetImpl querySet, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySetImpl querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(QueueImpl* queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(QueueImpl* queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(ref QueueImpl queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public partial void QueueOnSubmittedWorkDone<T0>(ref QueueImpl queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(QueueImpl* queue, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(QueueImpl* queue, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(QueueImpl* queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(ref QueueImpl queue, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref QueueImpl queue, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref QueueImpl queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(QueueImpl* queue, uint commandCount, CommandBufferImpl** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(QueueImpl* queue, uint commandCount, ref CommandBufferImpl* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref QueueImpl queue, uint commandCount, CommandBufferImpl** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref QueueImpl queue, uint commandCount, ref CommandBufferImpl* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(QueueImpl* queue, BufferImpl* buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(QueueImpl* queue, BufferImpl* buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(QueueImpl* queue, ref BufferImpl buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(QueueImpl* queue, ref BufferImpl buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref QueueImpl queue, BufferImpl* buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(ref QueueImpl queue, BufferImpl* buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref QueueImpl queue, ref BufferImpl buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public partial void QueueWriteBuffer<T0>(ref QueueImpl queue, ref BufferImpl buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(QueueImpl* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(QueueImpl* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref QueueImpl queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref QueueImpl queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public partial void QueueWriteTexture<T0>(ref QueueImpl queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1516, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public unsafe partial void RenderBundleEncoderDraw(RenderBundleEncoderImpl* renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1516, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public partial void RenderBundleEncoderDraw(ref RenderBundleEncoderImpl renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1517, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public unsafe partial void RenderBundleEncoderDrawIndexed(RenderBundleEncoderImpl* renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1517, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public partial void RenderBundleEncoderDrawIndexed(ref RenderBundleEncoderImpl renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoderImpl* renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoderImpl* renderBundleEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoderImpl renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoderImpl renderBundleEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoderImpl* renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoderImpl* renderBundleEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoderImpl renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoderImpl renderBundleEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundleImpl* RenderBundleEncoderFinish(RenderBundleEncoderImpl* renderBundleEncoder, RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundleImpl* RenderBundleEncoderFinish(RenderBundleEncoderImpl* renderBundleEncoder, ref RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundleImpl* RenderBundleEncoderFinish(ref RenderBundleEncoderImpl renderBundleEncoder, RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundleImpl* RenderBundleEncoderFinish(ref RenderBundleEncoderImpl renderBundleEncoder, ref RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoderImpl* renderBundleEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoderImpl* renderBundleEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoderImpl* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoderImpl renderBundleEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoderImpl renderBundleEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoderImpl renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public unsafe partial void RenderBundleEncoderPopDebugGroup(RenderBundleEncoderImpl* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public partial void RenderBundleEncoderPopDebugGroup(ref RenderBundleEncoderImpl renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoderImpl* renderBundleEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoderImpl* renderBundleEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoderImpl* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoderImpl renderBundleEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoderImpl renderBundleEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoderImpl renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoderImpl renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoderImpl renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoderImpl renderBundleEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoderImpl renderBundleEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoderImpl* renderBundleEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoderImpl* renderBundleEncoder, ref BufferImpl buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoderImpl renderBundleEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoderImpl renderBundleEncoder, ref BufferImpl buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoderImpl* renderBundleEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoderImpl* renderBundleEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoderImpl* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoderImpl renderBundleEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoderImpl renderBundleEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoderImpl renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoderImpl* renderBundleEncoder, RenderPipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoderImpl* renderBundleEncoder, ref RenderPipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoderImpl renderBundleEncoder, RenderPipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoderImpl renderBundleEncoder, ref RenderPipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoderImpl* renderBundleEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoderImpl* renderBundleEncoder, uint slot, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoderImpl renderBundleEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoderImpl renderBundleEncoder, uint slot, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public unsafe partial void RenderPassEncoderBeginOcclusionQuery(RenderPassEncoderImpl* renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public partial void RenderPassEncoderBeginOcclusionQuery(ref RenderPassEncoderImpl renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoderImpl* renderPassEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoderImpl* renderPassEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(ref RenderPassEncoderImpl renderPassEncoder, QuerySetImpl* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public partial void RenderPassEncoderBeginPipelineStatisticsQuery(ref RenderPassEncoderImpl renderPassEncoder, ref QuerySetImpl querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public unsafe partial void RenderPassEncoderDraw(RenderPassEncoderImpl* renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public partial void RenderPassEncoderDraw(ref RenderPassEncoderImpl renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public unsafe partial void RenderPassEncoderDrawIndexed(RenderPassEncoderImpl* renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public partial void RenderPassEncoderDrawIndexed(ref RenderPassEncoderImpl renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoderImpl* renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoderImpl* renderPassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoderImpl renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoderImpl renderPassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoderImpl* renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoderImpl* renderPassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoderImpl renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoderImpl renderPassEncoder, ref BufferImpl indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public unsafe partial void RenderPassEncoderEnd(RenderPassEncoderImpl* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public partial void RenderPassEncoderEnd(ref RenderPassEncoderImpl renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public unsafe partial void RenderPassEncoderEndOcclusionQuery(RenderPassEncoderImpl* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public partial void RenderPassEncoderEndOcclusionQuery(ref RenderPassEncoderImpl renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoderImpl* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public partial void RenderPassEncoderEndPipelineStatisticsQuery(ref RenderPassEncoderImpl renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoderImpl* renderPassEncoder, uint bundlesCount, RenderBundleImpl** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoderImpl* renderPassEncoder, uint bundlesCount, ref RenderBundleImpl* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoderImpl renderPassEncoder, uint bundlesCount, RenderBundleImpl** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoderImpl renderPassEncoder, uint bundlesCount, ref RenderBundleImpl* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoderImpl* renderPassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoderImpl* renderPassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoderImpl* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoderImpl renderPassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoderImpl renderPassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoderImpl renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public unsafe partial void RenderPassEncoderPopDebugGroup(RenderPassEncoderImpl* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public partial void RenderPassEncoderPopDebugGroup(ref RenderPassEncoderImpl renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoderImpl* renderPassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoderImpl* renderPassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoderImpl* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoderImpl renderPassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoderImpl renderPassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoderImpl renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoderImpl renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoderImpl renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoderImpl renderPassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoderImpl renderPassEncoder, uint groupIndex, ref BindGroupImpl group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoderImpl* renderPassEncoder, Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoderImpl* renderPassEncoder, ref Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoderImpl renderPassEncoder, Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoderImpl renderPassEncoder, ref Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoderImpl* renderPassEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoderImpl* renderPassEncoder, ref BufferImpl buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoderImpl renderPassEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoderImpl renderPassEncoder, ref BufferImpl buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoderImpl* renderPassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoderImpl* renderPassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoderImpl* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(ref RenderPassEncoderImpl renderPassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoderImpl renderPassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoderImpl renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoderImpl* renderPassEncoder, RenderPipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoderImpl* renderPassEncoder, ref RenderPipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(ref RenderPassEncoderImpl renderPassEncoder, RenderPipelineImpl* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public partial void RenderPassEncoderSetPipeline(ref RenderPassEncoderImpl renderPassEncoder, ref RenderPipelineImpl pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public unsafe partial void RenderPassEncoderSetScissorRect(RenderPassEncoderImpl* renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public partial void RenderPassEncoderSetScissorRect(ref RenderPassEncoderImpl renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public unsafe partial void RenderPassEncoderSetStencilReference(RenderPassEncoderImpl* renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public partial void RenderPassEncoderSetStencilReference(ref RenderPassEncoderImpl renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoderImpl* renderPassEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoderImpl* renderPassEncoder, uint slot, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoderImpl renderPassEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoderImpl renderPassEncoder, uint slot, ref BufferImpl buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public unsafe partial void RenderPassEncoderSetViewport(RenderPassEncoderImpl* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public partial void RenderPassEncoderSetViewport(ref RenderPassEncoderImpl renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* RenderPipelineGetBindGroupLayout(RenderPipelineImpl* renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 33 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayoutImpl* RenderPipelineGetBindGroupLayout(ref RenderPipelineImpl renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipelineImpl* renderPipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipelineImpl* renderPipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipelineImpl* renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(ref RenderPipelineImpl renderPipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipelineImpl renderPipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipelineImpl renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(SamplerImpl* sampler, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(SamplerImpl* sampler, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(SamplerImpl* sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(ref SamplerImpl sampler, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref SamplerImpl sampler, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref SamplerImpl sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModuleImpl* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModuleImpl* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ref ShaderModuleImpl shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public partial void ShaderModuleGetCompilationInfo<T0>(ref ShaderModuleImpl shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModuleImpl* shaderModule, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModuleImpl* shaderModule, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModuleImpl* shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ref ShaderModuleImpl shaderModule, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModuleImpl shaderModule, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModuleImpl shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(SurfaceImpl* surface, AdapterImpl* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(SurfaceImpl* surface, ref AdapterImpl adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(ref SurfaceImpl surface, AdapterImpl* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public partial TextureFormat SurfaceGetPreferredFormat(ref SurfaceImpl surface, ref AdapterImpl adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureViewImpl* SwapChainGetCurrentTextureView(SwapChainImpl* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureViewImpl* SwapChainGetCurrentTextureView(ref SwapChainImpl swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChainImpl* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public partial void SwapChainPresent(ref SwapChainImpl swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureViewImpl* TextureCreateView(TextureImpl* texture, TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureViewImpl* TextureCreateView(TextureImpl* texture, ref TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureViewImpl* TextureCreateView(ref TextureImpl texture, TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureViewImpl* TextureCreateView(ref TextureImpl texture, ref TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public unsafe partial void TextureDestroy(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public partial void TextureDestroy(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public unsafe partial uint TextureGetDepthOrArrayLayers(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public partial uint TextureGetDepthOrArrayLayers(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1576, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public unsafe partial TextureDimension TextureGetDimension(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1576, Column 34 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public partial TextureDimension TextureGetDimension(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public unsafe partial TextureFormat TextureGetFormat(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 31 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public partial TextureFormat TextureGetFormat(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public unsafe partial uint TextureGetHeight(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public partial uint TextureGetHeight(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1579, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public unsafe partial uint TextureGetMipLevelCount(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1579, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public partial uint TextureGetMipLevelCount(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1580, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public unsafe partial uint TextureGetSampleCount(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1580, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public partial uint TextureGetSampleCount(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public unsafe partial TextureUsage TextureGetUsage(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 30 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public partial TextureUsage TextureGetUsage(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public unsafe partial uint TextureGetWidth(TextureImpl* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 22 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public partial uint TextureGetWidth(ref TextureImpl texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(TextureImpl* texture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(TextureImpl* texture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(TextureImpl* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(ref TextureImpl texture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref TextureImpl texture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref TextureImpl texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureViewImpl* textureView, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureViewImpl* textureView, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureViewImpl* textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(ref TextureViewImpl textureView, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureViewImpl textureView, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureViewImpl textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);


        public WebGPU(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

