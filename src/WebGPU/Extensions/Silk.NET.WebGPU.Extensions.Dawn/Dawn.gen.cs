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
    public unsafe partial class Dawn : NativeExtension<Dawn>
    {
        public const string ExtensionName = "dawn-webgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance(InstanceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCreateInstance")]
        public unsafe partial Instance* CreateInstance(ref InstanceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, ref byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(ref Device device, byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref Device device, ref byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public partial PfnProc GetProcAddress(ref Device device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, ref DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(ref Adapter adapter, DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(ref Adapter adapter, ref DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(ref Adapter adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public partial nuint AdapterEnumerateFeatures(ref Adapter adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(Adapter* adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(Adapter* adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial bool AdapterGetLimits(ref Adapter adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public partial bool AdapterGetLimits(ref Adapter adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(Adapter* adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial void AdapterGetProperties(ref Adapter adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public partial void AdapterGetProperties(ref Adapter adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1605, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public unsafe partial bool AdapterHasFeature(Adapter* adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1605, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterHasFeature")]
        public partial bool AdapterHasFeature(ref Adapter adapter, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(ref Adapter adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(ref Adapter adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public partial void AdapterRequestDevice<T0>(ref Adapter adapter, ref DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterReference")]
        public unsafe partial void AdapterReference(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterReference")]
        public partial void AdapterReference(ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRelease")]
        public unsafe partial void AdapterRelease(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRelease")]
        public partial void AdapterRelease(ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(ref BindGroup bindGroup, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroup bindGroup, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public partial void BindGroupSetLabel(ref BindGroup bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupReference")]
        public unsafe partial void BindGroupReference(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupReference")]
        public partial void BindGroupReference(ref BindGroup bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupRelease")]
        public unsafe partial void BindGroupRelease(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupRelease")]
        public partial void BindGroupRelease(ref BindGroup bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public partial void BindGroupLayoutSetLabel(ref BindGroupLayout bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutReference")]
        public unsafe partial void BindGroupLayoutReference(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutReference")]
        public partial void BindGroupLayoutReference(ref BindGroupLayout bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutRelease")]
        public unsafe partial void BindGroupLayoutRelease(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutRelease")]
        public partial void BindGroupLayoutRelease(ref BindGroupLayout bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1621, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public unsafe partial void BufferDestroy(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1621, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDestroy")]
        public partial void BufferDestroy(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1622, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1622, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetConstMappedRange")]
        public unsafe partial void* BufferGetConstMappedRange(ref Buffer buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1623, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(Buffer* buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1623, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetMappedRange")]
        public unsafe partial void* BufferGetMappedRange(ref Buffer buffer, nuint offset, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1624, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public unsafe partial ulong BufferGetSize(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1624, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetSize")]
        public partial ulong BufferGetSize(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1625, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public unsafe partial BufferUsage BufferGetUsage(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1625, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferGetUsage")]
        public partial BufferUsage BufferGetUsage(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(Buffer* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(Buffer* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(ref Buffer buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public partial void BufferMapAsync<T0>(ref Buffer buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(ref Buffer buffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref Buffer buffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public partial void BufferSetLabel(ref Buffer buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1628, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public unsafe partial void BufferUnmap(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1628, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferUnmap")]
        public partial void BufferUnmap(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReference")]
        public unsafe partial void BufferReference(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReference")]
        public partial void BufferReference(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferRelease")]
        public unsafe partial void BufferRelease(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferRelease")]
        public partial void BufferRelease(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public partial void CommandBufferSetLabel(ref CommandBuffer commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferReference")]
        public unsafe partial void CommandBufferReference(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferReference")]
        public partial void CommandBufferReference(ref CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferRelease")]
        public unsafe partial void CommandBufferRelease(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferRelease")]
        public partial void CommandBufferRelease(ref CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(CommandEncoder* commandEncoder, ref ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(ref CommandEncoder commandEncoder, ComputePassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginComputePass")]
        public unsafe partial ComputePassEncoder* CommandEncoderBeginComputePass(ref CommandEncoder commandEncoder, ref ComputePassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(CommandEncoder* commandEncoder, ref RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(ref CommandEncoder commandEncoder, RenderPassDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
        public unsafe partial RenderPassEncoder* CommandEncoderBeginRenderPass(ref CommandEncoder commandEncoder, ref RenderPassDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public unsafe partial void CommandEncoderClearBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderClearBuffer")]
        public partial void CommandEncoderClearBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, ref Buffer source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(CommandEncoder* commandEncoder, ref Buffer source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, Buffer* source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public unsafe partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, ref Buffer source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
        public partial void CommandEncoderCopyBufferToBuffer(ref CommandEncoder commandEncoder, ref Buffer source, ulong sourceOffset, ref Buffer destination, ulong destinationOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ImageCopyBuffer* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ref ImageCopyBuffer source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public partial void CommandEncoderCopyBufferToTexture(ref CommandEncoder commandEncoder, ref ImageCopyBuffer source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyBuffer* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public partial void CommandEncoderCopyTextureToBuffer(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyBuffer destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public partial void CommandEncoderCopyTextureToTexture(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(CommandEncoder* commandEncoder, ref CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(ref CommandEncoder commandEncoder, CommandBufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderFinish")]
        public unsafe partial CommandBuffer* CommandEncoderFinish(ref CommandEncoder commandEncoder, ref CommandBufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public partial void CommandEncoderInsertDebugMarker(ref CommandEncoder commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1649, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public unsafe partial void CommandEncoderPopDebugGroup(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1649, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
        public partial void CommandEncoderPopDebugGroup(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public partial void CommandEncoderPushDebugGroup(ref CommandEncoder commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(CommandEncoder* commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public unsafe partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
        public partial void CommandEncoderResolveQuerySet(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint firstQuery, uint queryCount, ref Buffer destination, ulong destinationOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public partial void CommandEncoderSetLabel(ref CommandEncoder commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, ref byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, ref byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, ref byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, ref byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(CommandEncoder* commandEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public unsafe partial void CommandEncoderWriteTimestamp(ref CommandEncoder commandEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
        public partial void CommandEncoderWriteTimestamp(ref CommandEncoder commandEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderReference")]
        public unsafe partial void CommandEncoderReference(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderReference")]
        public partial void CommandEncoderReference(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderRelease")]
        public unsafe partial void CommandEncoderRelease(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderRelease")]
        public partial void CommandEncoderRelease(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatch")]
        public unsafe partial void ComputePassEncoderDispatch(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatch")]
        public partial void ComputePassEncoderDispatch(ref ComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ComputePassEncoder* computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ref ComputePassEncoder computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public partial void ComputePassEncoderDispatchIndirect(ref ComputePassEncoder computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1661, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroups(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1661, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
        public partial void ComputePassEncoderDispatchWorkgroups(ref ComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ComputePassEncoder* computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public unsafe partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoder computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
        public partial void ComputePassEncoderDispatchWorkgroupsIndirect(ref ComputePassEncoder computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1663, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public unsafe partial void ComputePassEncoderEnd(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1663, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEnd")]
        public partial void ComputePassEncoderEnd(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPass")]
        public unsafe partial void ComputePassEncoderEndPass(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPass")]
        public partial void ComputePassEncoderEndPass(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public partial void ComputePassEncoderInsertDebugMarker(ref ComputePassEncoder computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1666, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public unsafe partial void ComputePassEncoderPopDebugGroup(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1666, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
        public partial void ComputePassEncoderPopDebugGroup(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public partial void ComputePassEncoderPushDebugGroup(ref ComputePassEncoder computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ComputePassEncoder* computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public unsafe partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
        public partial void ComputePassEncoderSetBindGroup(ref ComputePassEncoder computePassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public partial void ComputePassEncoderSetLabel(ref ComputePassEncoder computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ComputePassEncoder* computePassEncoder, ref ComputePipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public unsafe partial void ComputePassEncoderSetPipeline(ref ComputePassEncoder computePassEncoder, ComputePipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPipeline")]
        public partial void ComputePassEncoderSetPipeline(ref ComputePassEncoder computePassEncoder, ref ComputePipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ref ComputePassEncoder computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public partial void ComputePassEncoderWriteTimestamp(ref ComputePassEncoder computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderReference")]
        public unsafe partial void ComputePassEncoderReference(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderReference")]
        public partial void ComputePassEncoderReference(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderRelease")]
        public unsafe partial void ComputePassEncoderRelease(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderRelease")]
        public partial void ComputePassEncoderRelease(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ComputePipeline* computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* ComputePipelineGetBindGroupLayout(ref ComputePipeline computePipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public partial void ComputePipelineSetLabel(ref ComputePipeline computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineReference")]
        public unsafe partial void ComputePipelineReference(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineReference")]
        public partial void ComputePipelineReference(ref ComputePipeline computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineRelease")]
        public unsafe partial void ComputePipelineRelease(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineRelease")]
        public partial void ComputePipelineRelease(ref ComputePipeline computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(Device* device, ref BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(ref Device device, BindGroupDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroup")]
        public unsafe partial BindGroup* DeviceCreateBindGroup(ref Device device, ref BindGroupDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(Device* device, ref BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(ref Device device, BindGroupLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
        public unsafe partial BindGroupLayout* DeviceCreateBindGroupLayout(ref Device device, ref BindGroupLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(Device* device, ref BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(ref Device device, BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateBuffer")]
        public unsafe partial Buffer* DeviceCreateBuffer(ref Device device, ref BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(Device* device, ref CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(ref Device device, CommandEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateCommandEncoder")]
        public unsafe partial CommandEncoder* DeviceCreateCommandEncoder(ref Device device, ref CommandEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(Device* device, ref ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(ref Device device, ComputePipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipeline")]
        public unsafe partial ComputePipeline* DeviceCreateComputePipeline(ref Device device, ref ComputePipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(ref Device device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public partial void DeviceCreateComputePipelineAsync<T0>(ref Device device, ref ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(ref Device device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(ref Device device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, ref ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(ref Device device, ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(ref Device device, ref ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(Device* device, ref PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(ref Device device, PipelineLayoutDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreatePipelineLayout")]
        public unsafe partial PipelineLayout* DeviceCreatePipelineLayout(ref Device device, ref PipelineLayoutDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(Device* device, ref QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(ref Device device, QuerySetDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateQuerySet")]
        public unsafe partial QuerySet* DeviceCreateQuerySet(ref Device device, ref QuerySetDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(Device* device, ref RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(ref Device device, RenderBundleEncoderDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
        public unsafe partial RenderBundleEncoder* DeviceCreateRenderBundleEncoder(ref Device device, ref RenderBundleEncoderDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(Device* device, ref RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(ref Device device, RenderPipelineDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipeline")]
        public unsafe partial RenderPipeline* DeviceCreateRenderPipeline(ref Device device, ref RenderPipelineDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(ref Device device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public partial void DeviceCreateRenderPipelineAsync<T0>(ref Device device, ref RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(Device* device, ref SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(ref Device device, SamplerDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSampler")]
        public unsafe partial Sampler* DeviceCreateSampler(ref Device device, ref SamplerDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(Device* device, ref ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(ref Device device, ShaderModuleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateShaderModule(ref Device device, ref ShaderModuleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, ref Surface surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, ref Surface surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, Surface* surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, Surface* surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, ref Surface surface, SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(ref Device device, ref Surface surface, ref SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(Device* device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(ref Device device, TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateTexture")]
        public unsafe partial Texture* DeviceCreateTexture(ref Device device, ref TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1701, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public unsafe partial void DeviceDestroy(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1701, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDestroy")]
        public partial void DeviceDestroy(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(ref Device device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public partial nuint DeviceEnumerateFeatures(ref Device device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(ref Device device, DeviceLostReason type, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public partial void DeviceForceLoss(ref Device device, DeviceLostReason type, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public partial void DeviceForceLoss(ref Device device, DeviceLostReason type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(Device* device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(Device* device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial bool DeviceGetLimits(ref Device device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public partial bool DeviceGetLimits(ref Device device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1706, Column 23 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1706, Column 23 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetQueue")]
        public unsafe partial Queue* DeviceGetQueue(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1707, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public unsafe partial bool DeviceHasFeature(Device* device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1707, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceHasFeature")]
        public partial bool DeviceHasFeature(ref Device device, FeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(ref Device device, ErrorType type, byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public partial void DeviceInjectError(ref Device device, ErrorType type, ref byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public partial void DeviceInjectError(ref Device device, ErrorType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial bool DevicePopErrorScope(ref Device device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public partial bool DevicePopErrorScope<T0>(ref Device device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public unsafe partial void DevicePushErrorScope(Device* device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePushErrorScope")]
        public partial void DevicePushErrorScope(ref Device device, ErrorFilter filter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(ref Device device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public partial void DeviceSetDeviceLostCallback<T0>(ref Device device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(ref Device device, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref Device device, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public partial void DeviceSetLabel(ref Device device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(Device* device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback<T0>(Device* device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(ref Device device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public partial void DeviceSetLoggingCallback<T0>(ref Device device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(ref Device device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public partial void DeviceSetUncapturedErrorCallback<T0>(ref Device device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public unsafe partial void DeviceTick(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public partial void DeviceTick(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceReference")]
        public unsafe partial void DeviceReference(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceReference")]
        public partial void DeviceReference(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceRelease")]
        public unsafe partial void DeviceRelease(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceRelease")]
        public partial void DeviceRelease(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public unsafe partial void ExternalTextureDestroy(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public partial void ExternalTextureDestroy(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public unsafe partial void ExternalTextureReference(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public partial void ExternalTextureReference(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public partial void ExternalTextureRelease(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(Instance* instance, ref SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(ref Instance instance, SurfaceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceCreateSurface")]
        public unsafe partial Surface* InstanceCreateSurface(ref Instance instance, ref SurfaceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(ref Instance instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(ref Instance instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public partial void InstanceRequestAdapter<T0>(ref Instance instance, ref RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceReference")]
        public unsafe partial void InstanceReference(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceReference")]
        public partial void InstanceReference(ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRelease")]
        public unsafe partial void InstanceRelease(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRelease")]
        public partial void InstanceRelease(ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public partial void PipelineLayoutSetLabel(ref PipelineLayout pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutReference")]
        public unsafe partial void PipelineLayoutReference(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutReference")]
        public partial void PipelineLayoutReference(ref PipelineLayout pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutRelease")]
        public unsafe partial void PipelineLayoutRelease(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutRelease")]
        public partial void PipelineLayoutRelease(ref PipelineLayout pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1737, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public unsafe partial void QuerySetDestroy(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1737, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDestroy")]
        public partial void QuerySetDestroy(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public unsafe partial uint QuerySetGetCount(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetCount")]
        public partial uint QuerySetGetCount(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public unsafe partial QueryType QuerySetGetType(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetGetType")]
        public partial QueryType QuerySetGetType(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(ref QuerySet querySet, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySet querySet, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public partial void QuerySetSetLabel(ref QuerySet querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetReference")]
        public unsafe partial void QuerySetReference(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetReference")]
        public partial void QuerySetReference(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetRelease")]
        public unsafe partial void QuerySetRelease(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetRelease")]
        public partial void QuerySetRelease(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ImageCopyExternalTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public partial void QueueCopyExternalTextureForBrowser(ref Queue queue, ref ImageCopyExternalTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ImageCopyTexture* source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ImageCopyTexture* destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ImageCopyTexture* destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, Extent3D* copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public partial void QueueCopyTextureForBrowser(ref Queue queue, ref ImageCopyTexture source, ref ImageCopyTexture destination, ref Extent3D copySize, ref CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, ulong signalValue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, ulong signalValue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(ref Queue queue, ulong signalValue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public partial void QueueOnSubmittedWorkDone<T0>(ref Queue queue, ulong signalValue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(ref Queue queue, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref Queue queue, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public partial void QueueSetLabel(ref Queue queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(Queue* queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref Queue queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmit")]
        public unsafe partial void QueueSubmit(ref Queue queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, Buffer* buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, Buffer* buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(Queue* queue, ref Buffer buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(Queue* queue, ref Buffer buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, Buffer* buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer<T0>(ref Queue queue, Buffer* buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public unsafe partial void QueueWriteBuffer(ref Queue queue, ref Buffer buffer, ulong bufferOffset, void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteBuffer")]
        public partial void QueueWriteBuffer<T0>(ref Queue queue, ref Buffer buffer, ulong bufferOffset, ref T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ImageCopyTexture* destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ImageCopyTexture* destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ref ImageCopyTexture destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(ref Queue queue, ref ImageCopyTexture destination, void* data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, TextureDataLayout* dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(ref Queue queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public partial void QueueWriteTexture<T0>(ref Queue queue, ref ImageCopyTexture destination, ref T0 data, nuint dataSize, ref TextureDataLayout dataLayout, ref Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueReference")]
        public unsafe partial void QueueReference(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueReference")]
        public partial void QueueReference(ref Queue queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueRelease")]
        public unsafe partial void QueueRelease(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueRelease")]
        public partial void QueueRelease(ref Queue queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleReference")]
        public unsafe partial void RenderBundleReference(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleReference")]
        public partial void RenderBundleReference(ref RenderBundle renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleRelease")]
        public unsafe partial void RenderBundleRelease(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleRelease")]
        public partial void RenderBundleRelease(ref RenderBundle renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1760, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public unsafe partial void RenderBundleEncoderDraw(RenderBundleEncoder* renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1760, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDraw")]
        public partial void RenderBundleEncoderDraw(ref RenderBundleEncoder renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1761, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public unsafe partial void RenderBundleEncoderDrawIndexed(RenderBundleEncoder* renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1761, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
        public partial void RenderBundleEncoderDrawIndexed(ref RenderBundleEncoder renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(RenderBundleEncoder* renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoder renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndexedIndirect")]
        public partial void RenderBundleEncoderDrawIndexedIndirect(ref RenderBundleEncoder renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(RenderBundleEncoder* renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public unsafe partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoder renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrawIndirect")]
        public partial void RenderBundleEncoderDrawIndirect(ref RenderBundleEncoder renderBundleEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(RenderBundleEncoder* renderBundleEncoder, ref RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(ref RenderBundleEncoder renderBundleEncoder, RenderBundleDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderFinish")]
        public unsafe partial RenderBundle* RenderBundleEncoderFinish(ref RenderBundleEncoder renderBundleEncoder, ref RenderBundleDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public partial void RenderBundleEncoderInsertDebugMarker(ref RenderBundleEncoder renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1766, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public unsafe partial void RenderBundleEncoderPopDebugGroup(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1766, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
        public partial void RenderBundleEncoderPopDebugGroup(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public partial void RenderBundleEncoderPushDebugGroup(ref RenderBundleEncoder renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(RenderBundleEncoder* renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public unsafe partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
        public partial void RenderBundleEncoderSetBindGroup(ref RenderBundleEncoder renderBundleEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(RenderBundleEncoder* renderBundleEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public unsafe partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoder renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
        public partial void RenderBundleEncoderSetIndexBuffer(ref RenderBundleEncoder renderBundleEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public partial void RenderBundleEncoderSetLabel(ref RenderBundleEncoder renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(RenderBundleEncoder* renderBundleEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public unsafe partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoder renderBundleEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
        public partial void RenderBundleEncoderSetPipeline(ref RenderBundleEncoder renderBundleEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(RenderBundleEncoder* renderBundleEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public unsafe partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoder renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
        public partial void RenderBundleEncoderSetVertexBuffer(ref RenderBundleEncoder renderBundleEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderReference")]
        public unsafe partial void RenderBundleEncoderReference(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderReference")]
        public partial void RenderBundleEncoderReference(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderRelease")]
        public unsafe partial void RenderBundleEncoderRelease(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderRelease")]
        public partial void RenderBundleEncoderRelease(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public unsafe partial void RenderPassEncoderBeginOcclusionQuery(RenderPassEncoder* renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
        public partial void RenderPassEncoderBeginOcclusionQuery(ref RenderPassEncoder renderPassEncoder, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1778, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public unsafe partial void RenderPassEncoderDraw(RenderPassEncoder* renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1778, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDraw")]
        public partial void RenderPassEncoderDraw(ref RenderPassEncoder renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1779, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public unsafe partial void RenderPassEncoderDrawIndexed(RenderPassEncoder* renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1779, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
        public partial void RenderPassEncoderDrawIndexed(ref RenderPassEncoder renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(RenderPassEncoder* renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoder renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
        public partial void RenderPassEncoderDrawIndexedIndirect(ref RenderPassEncoder renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(RenderPassEncoder* renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public unsafe partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoder renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
        public partial void RenderPassEncoderDrawIndirect(ref RenderPassEncoder renderPassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1782, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public unsafe partial void RenderPassEncoderEnd(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1782, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEnd")]
        public partial void RenderPassEncoderEnd(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1783, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public unsafe partial void RenderPassEncoderEndOcclusionQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1783, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
        public partial void RenderPassEncoderEndOcclusionQuery(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPass")]
        public unsafe partial void RenderPassEncoderEndPass(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPass")]
        public partial void RenderPassEncoderEndPass(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundleCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(RenderPassEncoder* renderPassEncoder, uint bundleCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoder renderPassEncoder, uint bundleCount, RenderBundle** bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
        public unsafe partial void RenderPassEncoderExecuteBundles(ref RenderPassEncoder renderPassEncoder, uint bundleCount, ref RenderBundle* bundles);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, ref byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public partial void RenderPassEncoderInsertDebugMarker(ref RenderPassEncoder renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1787, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public unsafe partial void RenderPassEncoderPopDebugGroup(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1787, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
        public partial void RenderPassEncoderPopDebugGroup(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, ref byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public partial void RenderPassEncoderPushDebugGroup(ref RenderPassEncoder renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(RenderPassEncoder* renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public unsafe partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, uint* dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
        public partial void RenderPassEncoderSetBindGroup(ref RenderPassEncoder renderPassEncoder, uint groupIndex, ref BindGroup group, uint dynamicOffsetCount, ref uint dynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(RenderPassEncoder* renderPassEncoder, ref Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public unsafe partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoder renderPassEncoder, Color* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
        public partial void RenderPassEncoderSetBlendConstant(ref RenderPassEncoder renderPassEncoder, ref Color color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(RenderPassEncoder* renderPassEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public unsafe partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoder renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
        public partial void RenderPassEncoderSetIndexBuffer(ref RenderPassEncoder renderPassEncoder, ref Buffer buffer, IndexFormat format, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public partial void RenderPassEncoderSetLabel(ref RenderPassEncoder renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(RenderPassEncoder* renderPassEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public unsafe partial void RenderPassEncoderSetPipeline(ref RenderPassEncoder renderPassEncoder, RenderPipeline* pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
        public partial void RenderPassEncoderSetPipeline(ref RenderPassEncoder renderPassEncoder, ref RenderPipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1794, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public unsafe partial void RenderPassEncoderSetScissorRect(RenderPassEncoder* renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1794, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
        public partial void RenderPassEncoderSetScissorRect(ref RenderPassEncoder renderPassEncoder, uint x, uint y, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1795, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public unsafe partial void RenderPassEncoderSetStencilReference(RenderPassEncoder* renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1795, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
        public partial void RenderPassEncoderSetStencilReference(ref RenderPassEncoder renderPassEncoder, uint reference);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(RenderPassEncoder* renderPassEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public unsafe partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoder renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
        public partial void RenderPassEncoderSetVertexBuffer(ref RenderPassEncoder renderPassEncoder, uint slot, ref Buffer buffer, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1797, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public unsafe partial void RenderPassEncoderSetViewport(RenderPassEncoder* renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1797, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetViewport")]
        public partial void RenderPassEncoderSetViewport(ref RenderPassEncoder renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(ref RenderPassEncoder renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public partial void RenderPassEncoderWriteTimestamp(ref RenderPassEncoder renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderReference")]
        public unsafe partial void RenderPassEncoderReference(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderReference")]
        public partial void RenderPassEncoderReference(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderRelease")]
        public unsafe partial void RenderPassEncoderRelease(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderRelease")]
        public partial void RenderPassEncoderRelease(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(RenderPipeline* renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
        public unsafe partial BindGroupLayout* RenderPipelineGetBindGroupLayout(ref RenderPipeline renderPipeline, uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public partial void RenderPipelineSetLabel(ref RenderPipeline renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineReference")]
        public unsafe partial void RenderPipelineReference(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineReference")]
        public partial void RenderPipelineReference(ref RenderPipeline renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineRelease")]
        public unsafe partial void RenderPipelineRelease(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineRelease")]
        public partial void RenderPipelineRelease(ref RenderPipeline renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(ref Sampler sampler, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref Sampler sampler, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public partial void SamplerSetLabel(ref Sampler sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerReference")]
        public unsafe partial void SamplerReference(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerReference")]
        public partial void SamplerReference(ref Sampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerRelease")]
        public unsafe partial void SamplerRelease(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerRelease")]
        public partial void SamplerRelease(ref Sampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ref ShaderModule shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public partial void ShaderModuleGetCompilationInfo<T0>(ref ShaderModule shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public partial void ShaderModuleSetLabel(ref ShaderModule shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleReference")]
        public unsafe partial void ShaderModuleReference(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleReference")]
        public partial void ShaderModuleReference(ref ShaderModule shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleRelease")]
        public unsafe partial void ShaderModuleRelease(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleRelease")]
        public partial void ShaderModuleRelease(ref ShaderModule shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceReference")]
        public unsafe partial void SurfaceReference(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceReference")]
        public partial void SurfaceReference(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceRelease")]
        public unsafe partial void SurfaceRelease(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceRelease")]
        public partial void SurfaceRelease(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainConfigure")]
        public unsafe partial void SwapChainConfigure(SwapChain* swapChain, TextureFormat format, uint allowedUsage, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainConfigure")]
        public partial void SwapChainConfigure(ref SwapChain swapChain, TextureFormat format, uint allowedUsage, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1825, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1825, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public partial void SwapChainPresent(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public unsafe partial void SwapChainReference(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public partial void SwapChainReference(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public unsafe partial void SwapChainRelease(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public partial void SwapChainRelease(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(Texture* texture, ref TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(ref Texture texture, TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateView")]
        public unsafe partial TextureView* TextureCreateView(ref Texture texture, ref TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1832, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public unsafe partial void TextureDestroy(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1832, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDestroy")]
        public partial void TextureDestroy(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1833, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public unsafe partial uint TextureGetDepthOrArrayLayers(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1833, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
        public partial uint TextureGetDepthOrArrayLayers(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1834, Column 34 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public unsafe partial TextureDimension TextureGetDimension(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1834, Column 34 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetDimension")]
        public partial TextureDimension TextureGetDimension(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1835, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public unsafe partial TextureFormat TextureGetFormat(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1835, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetFormat")]
        public partial TextureFormat TextureGetFormat(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1836, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public unsafe partial uint TextureGetHeight(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1836, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetHeight")]
        public partial uint TextureGetHeight(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public unsafe partial uint TextureGetMipLevelCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetMipLevelCount")]
        public partial uint TextureGetMipLevelCount(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1838, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public unsafe partial uint TextureGetSampleCount(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1838, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetSampleCount")]
        public partial uint TextureGetSampleCount(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1839, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public unsafe partial TextureUsage TextureGetUsage(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1839, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetUsage")]
        public partial TextureUsage TextureGetUsage(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1840, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public unsafe partial uint TextureGetWidth(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1840, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureGetWidth")]
        public partial uint TextureGetWidth(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(ref Texture texture, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref Texture texture, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public partial void TextureSetLabel(ref Texture texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureReference")]
        public unsafe partial void TextureReference(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureReference")]
        public partial void TextureReference(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureRelease")]
        public unsafe partial void TextureRelease(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureRelease")]
        public partial void TextureRelease(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(ref TextureView textureView, byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureView textureView, ref byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public partial void TextureViewSetLabel(ref TextureView textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewReference")]
        public unsafe partial void TextureViewReference(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewReference")]
        public partial void TextureViewReference(ref TextureView textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewRelease")]
        public unsafe partial void TextureViewRelease(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewRelease")]
        public partial void TextureViewRelease(ref TextureView textureView);

        public Dawn(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

