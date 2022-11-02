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
        [NativeName("Src", "Line 1597, Column 26 in dawn-webgpu.h")]
        public static unsafe Instance* CreateInstance(this Dawn thisApi, Span<InstanceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this Dawn thisApi, Device* device, Span<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(device, ref procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this Dawn thisApi, Span<Device> device, byte* procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this Dawn thisApi, Span<Device> device, Span<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), ref procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 22 in dawn-webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this Dawn thisApi, Span<Device> device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Adapter* adapter, Span<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(adapter, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Span<Adapter> adapter, DeviceDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(ref adapter.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Span<Adapter> adapter, Span<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(ref adapter.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this Dawn thisApi, Adapter* adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(adapter, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this Dawn thisApi, Span<Adapter> adapter, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1602, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this Dawn thisApi, Span<Adapter> adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        public static unsafe bool AdapterGetLimits(this Dawn thisApi, Adapter* adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(adapter, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        public static unsafe bool AdapterGetLimits(this Dawn thisApi, Span<Adapter> adapter, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1603, Column 18 in dawn-webgpu.h")]
        public static unsafe bool AdapterGetLimits(this Dawn thisApi, Span<Adapter> adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterGetProperties(this Dawn thisApi, Adapter* adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(adapter, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterGetProperties(this Dawn thisApi, Span<Adapter> adapter, AdapterProperties* properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1604, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterGetProperties(this Dawn thisApi, Span<Adapter> adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1605, Column 18 in dawn-webgpu.h")]
        public static unsafe bool AdapterHasFeature(this Dawn thisApi, Span<Adapter> adapter, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.AdapterHasFeature(ref adapter.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this Dawn thisApi, Adapter* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice(this Dawn thisApi, Adapter* adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this Dawn thisApi, Adapter* adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice(this Dawn thisApi, Span<Adapter> adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this Dawn thisApi, Span<Adapter> adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice(this Dawn thisApi, Span<Adapter> adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1606, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this Dawn thisApi, Span<Adapter> adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterReference(this Dawn thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterReference(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRelease(this Dawn thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterRelease(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupSetLabel(this Dawn thisApi, BindGroup* bindGroup, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(bindGroup, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupSetLabel(this Dawn thisApi, Span<BindGroup> bindGroup, byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupSetLabel(this Dawn thisApi, Span<BindGroup> bindGroup, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1611, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupSetLabel(this Dawn thisApi, Span<BindGroup> bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupReference(this Dawn thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupReference(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupRelease(this Dawn thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupRelease(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this Dawn thisApi, BindGroupLayout* bindGroupLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(bindGroupLayout, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout, byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutReference(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutReference(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutRelease(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutRelease(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1621, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferDestroy(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferDestroy(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1622, Column 26 in dawn-webgpu.h")]
        public static unsafe void* BufferGetConstMappedRange(this Dawn thisApi, Span<Buffer> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetConstMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1623, Column 20 in dawn-webgpu.h")]
        public static unsafe void* BufferGetMappedRange(this Dawn thisApi, Span<Buffer> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1624, Column 22 in dawn-webgpu.h")]
        public static unsafe ulong BufferGetSize(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetSize(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1625, Column 29 in dawn-webgpu.h")]
        public static unsafe BufferUsage BufferGetUsage(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetUsage(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this Dawn thisApi, Buffer* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(buffer, mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferMapAsync(this Dawn thisApi, Span<Buffer> buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1626, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this Dawn thisApi, Span<Buffer> buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferSetLabel(this Dawn thisApi, Buffer* buffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(buffer, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferSetLabel(this Dawn thisApi, Span<Buffer> buffer, byte* label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferSetLabel(this Dawn thisApi, Span<Buffer> buffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferSetLabel(this Dawn thisApi, Span<Buffer> buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1628, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferUnmap(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferUnmap(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferReference(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferReference(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferRelease(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferRelease(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this Dawn thisApi, CommandBuffer* commandBuffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(commandBuffer, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this Dawn thisApi, Span<CommandBuffer> commandBuffer, byte* label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this Dawn thisApi, Span<CommandBuffer> commandBuffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1633, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this Dawn thisApi, Span<CommandBuffer> commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferReference(this Dawn thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferReference(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferRelease(this Dawn thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferRelease(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ComputePassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1638, Column 36 in dawn-webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this Dawn thisApi, CommandEncoder* commandEncoder, Span<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this Dawn thisApi, Span<CommandEncoder> commandEncoder, RenderPassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1639, Column 35 in dawn-webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(commandEncoder, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1640, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1641, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1643, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this Dawn thisApi, CommandEncoder* commandEncoder, Span<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this Dawn thisApi, Span<CommandEncoder> commandEncoder, CommandBufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1646, Column 31 in dawn-webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, CommandEncoder* commandEncoder, Span<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(commandEncoder, ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, byte* message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this Dawn thisApi, CommandEncoder* commandEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(commandEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this Dawn thisApi, Span<CommandEncoder> commandEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1648, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1649, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderPopDebugGroup(this Dawn thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderPopDebugGroup(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this Dawn thisApi, CommandEncoder* commandEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(commandEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this Dawn thisApi, Span<CommandEncoder> commandEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1650, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this Dawn thisApi, CommandEncoder* commandEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(commandEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this Dawn thisApi, Span<CommandEncoder> commandEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1652, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, Span<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, Span<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, Span<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, Span<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this Dawn thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(commandEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this Dawn thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderReference(this Dawn thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderReference(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderRelease(this Dawn thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderRelease(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatch(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatch(ref computePassEncoder.GetPinnableReference(), workgroupCountX, workgroupCountY, workgroupCountZ);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(computePassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(ref computePassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(ref computePassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1661, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroups(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroups(ref computePassEncoder.GetPinnableReference(), workgroupCountX, workgroupCountY, workgroupCountZ);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(computePassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1662, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1663, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderEnd(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEnd(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderEndPass(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEndPass(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(computePassEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1665, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1666, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderPopDebugGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPopDebugGroup(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(computePassEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1667, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1668, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(computePassEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<ComputePipeline> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(computePassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, ComputePipeline* pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<ComputePipeline> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(computePassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(ref computePassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(ref computePassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderReference(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderReference(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderRelease(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderRelease(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 33 in dawn-webgpu.h")]
        public static unsafe BindGroupLayout* ComputePipelineGetBindGroupLayout(this Dawn thisApi, Span<ComputePipeline> computePipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.ComputePipelineGetBindGroupLayout(ref computePipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this Dawn thisApi, ComputePipeline* computePipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(computePipeline, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this Dawn thisApi, Span<ComputePipeline> computePipeline, byte* label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this Dawn thisApi, Span<ComputePipeline> computePipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1677, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this Dawn thisApi, Span<ComputePipeline> computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineReference(this Dawn thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineReference(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineRelease(this Dawn thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineRelease(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this Dawn thisApi, Device* device, Span<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this Dawn thisApi, Span<Device> device, BindGroupDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1682, Column 27 in dawn-webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this Dawn thisApi, Span<Device> device, Span<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this Dawn thisApi, Device* device, Span<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this Dawn thisApi, Span<Device> device, BindGroupLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 33 in dawn-webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this Dawn thisApi, Span<Device> device, Span<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this Dawn thisApi, Device* device, Span<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this Dawn thisApi, Span<Device> device, BufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this Dawn thisApi, Span<Device> device, Span<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this Dawn thisApi, Device* device, Span<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this Dawn thisApi, Span<Device> device, CommandEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1685, Column 32 in dawn-webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this Dawn thisApi, Span<Device> device, Span<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this Dawn thisApi, Device* device, Span<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this Dawn thisApi, Span<Device> device, ComputePipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 33 in dawn-webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this Dawn thisApi, Span<Device> device, Span<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this Dawn thisApi, Device* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this Dawn thisApi, Device* device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this Dawn thisApi, Device* device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this Dawn thisApi, Span<Device> device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this Dawn thisApi, Span<Device> device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this Dawn thisApi, Span<Device> device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1687, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this Dawn thisApi, Span<Device> device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateErrorBuffer(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorBuffer(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateErrorExternalTexture(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorExternalTexture(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Device* device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Span<Device> device, TextureDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Span<Device> device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Device* device, Span<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(device, ref externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Span<Device> device, ExternalTextureDescriptor* externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(ref device.GetPinnableReference(), externalTextureDescriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Span<Device> device, Span<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(ref device.GetPinnableReference(), ref externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this Dawn thisApi, Device* device, Span<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this Dawn thisApi, Span<Device> device, PipelineLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 32 in dawn-webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this Dawn thisApi, Span<Device> device, Span<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this Dawn thisApi, Device* device, Span<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this Dawn thisApi, Span<Device> device, QuerySetDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1693, Column 26 in dawn-webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this Dawn thisApi, Span<Device> device, Span<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this Dawn thisApi, Device* device, Span<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this Dawn thisApi, Span<Device> device, RenderBundleEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1694, Column 37 in dawn-webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this Dawn thisApi, Span<Device> device, Span<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this Dawn thisApi, Device* device, Span<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this Dawn thisApi, Span<Device> device, RenderPipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 32 in dawn-webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this Dawn thisApi, Span<Device> device, Span<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this Dawn thisApi, Device* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this Dawn thisApi, Device* device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this Dawn thisApi, Device* device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this Dawn thisApi, Span<Device> device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this Dawn thisApi, Span<Device> device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this Dawn thisApi, Span<Device> device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this Dawn thisApi, Span<Device> device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this Dawn thisApi, Device* device, Span<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this Dawn thisApi, Span<Device> device, SamplerDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1697, Column 25 in dawn-webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this Dawn thisApi, Span<Device> device, Span<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this Dawn thisApi, Device* device, Span<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this Dawn thisApi, Span<Device> device, ShaderModuleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1698, Column 30 in dawn-webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this Dawn thisApi, Span<Device> device, Span<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Device* device, Surface* surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Device* device, Span<Surface> surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Device* device, Span<Surface> surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Span<Device> device, Surface* surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Span<Device> device, Surface* surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Span<Device> device, Span<Surface> surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1699, Column 27 in dawn-webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this Dawn thisApi, Span<Device> device, Span<Surface> surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this Dawn thisApi, Device* device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this Dawn thisApi, Span<Device> device, TextureDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this Dawn thisApi, Span<Device> device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1701, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceDestroy(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceDestroy(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this Dawn thisApi, Device* device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(device, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this Dawn thisApi, Span<Device> device, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1702, Column 20 in dawn-webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this Dawn thisApi, Span<Device> device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Device* device, DeviceLostReason type, Span<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(device, type, ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, byte* message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, Span<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        public static unsafe Adapter* DeviceGetAdapter(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceGetAdapter(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DeviceGetLimits(this Dawn thisApi, Device* device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(device, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DeviceGetLimits(this Dawn thisApi, Span<Device> device, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1705, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DeviceGetLimits(this Dawn thisApi, Span<Device> device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1706, Column 23 in dawn-webgpu.h")]
        public static unsafe Queue* DeviceGetQueue(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceGetQueue(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1707, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DeviceHasFeature(this Dawn thisApi, Span<Device> device, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.DeviceHasFeature(ref device.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Device* device, ErrorType type, Span<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(device, type, ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, byte* message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, Span<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, ref message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DevicePopErrorScope<T0>(this Dawn thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DevicePopErrorScope(this Dawn thisApi, Span<Device> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1709, Column 18 in dawn-webgpu.h")]
        public static unsafe bool DevicePopErrorScope<T0>(this Dawn thisApi, Span<Device> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 18 in dawn-webgpu.h")]
        public static unsafe void DevicePushErrorScope(this Dawn thisApi, Span<Device> device, ErrorFilter filter)
        {
            // SpanOverloader
            thisApi.DevicePushErrorScope(ref device.GetPinnableReference(), filter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this Dawn thisApi, Device* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback(this Dawn thisApi, Span<Device> device, PfnDeviceLostCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1711, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this Dawn thisApi, Span<Device> device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLabel(this Dawn thisApi, Device* device, Span<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(device, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLabel(this Dawn thisApi, Span<Device> device, byte* label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLabel(this Dawn thisApi, Span<Device> device, Span<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1712, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLabel(this Dawn thisApi, Span<Device> device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Device* device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback(this Dawn thisApi, Span<Device> device, PfnLoggingCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Span<Device> device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this Dawn thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback(this Dawn thisApi, Span<Device> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1714, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this Dawn thisApi, Span<Device> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceTick(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceTick(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceReference(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceReference(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceRelease(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceRelease(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureDestroy(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureDestroy(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, ExternalTextureImpl* externalTexture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(externalTexture, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, byte* label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureReference(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureReference(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureRelease(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureRelease(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this Dawn thisApi, Instance* instance, Span<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(instance, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this Dawn thisApi, Span<Instance> instance, SurfaceDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1726, Column 25 in dawn-webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this Dawn thisApi, Span<Instance> instance, Span<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this Dawn thisApi, Instance* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this Dawn thisApi, Instance* instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, ref options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this Dawn thisApi, Instance* instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, ref options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this Dawn thisApi, Span<Instance> instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this Dawn thisApi, Span<Instance> instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this Dawn thisApi, Span<Instance> instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), ref options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1727, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this Dawn thisApi, Span<Instance> instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), ref options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceReference(this Dawn thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceReference(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRelease(this Dawn thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceRelease(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this Dawn thisApi, PipelineLayout* pipelineLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(pipelineLayout, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this Dawn thisApi, Span<PipelineLayout> pipelineLayout, byte* label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this Dawn thisApi, Span<PipelineLayout> pipelineLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1732, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this Dawn thisApi, Span<PipelineLayout> pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutReference(this Dawn thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutReference(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutRelease(this Dawn thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutRelease(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1737, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetDestroy(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetDestroy(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 22 in dawn-webgpu.h")]
        public static unsafe uint QuerySetGetCount(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetCount(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 27 in dawn-webgpu.h")]
        public static unsafe QueryType QuerySetGetType(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetType(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetSetLabel(this Dawn thisApi, QuerySet* querySet, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(querySet, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetSetLabel(this Dawn thisApi, Span<QuerySet> querySet, byte* label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetSetLabel(this Dawn thisApi, Span<QuerySet> querySet, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1740, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetSetLabel(this Dawn thisApi, Span<QuerySet> querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetReference(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetReference(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetRelease(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetRelease(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyExternalTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyExternalTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize, ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize, Span<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference(), ref options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this Dawn thisApi, Queue* queue, ulong signalValue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(queue, signalValue, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone(this Dawn thisApi, Span<Queue> queue, ulong signalValue, PfnQueueWorkDoneCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), signalValue, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1747, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this Dawn thisApi, Span<Queue> queue, ulong signalValue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), signalValue, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSetLabel(this Dawn thisApi, Queue* queue, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(queue, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSetLabel(this Dawn thisApi, Span<Queue> queue, byte* label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSetLabel(this Dawn thisApi, Span<Queue> queue, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSetLabel(this Dawn thisApi, Span<Queue> queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSubmit(this Dawn thisApi, Span<Queue> queue, uint commandCount, CommandBuffer** commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1749, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueSubmit(this Dawn thisApi, Span<Queue> queue, uint commandCount, ref CommandBuffer* commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, ref commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this Dawn thisApi, Queue* queue, Buffer* buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer(this Dawn thisApi, Queue* queue, Span<Buffer> buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this Dawn thisApi, Queue* queue, Span<Buffer> buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer(this Dawn thisApi, Span<Queue> queue, Buffer* buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this Dawn thisApi, Span<Queue> queue, Buffer* buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer(this Dawn thisApi, Span<Queue> queue, Span<Buffer> buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1750, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this Dawn thisApi, Span<Queue> queue, Span<Buffer> buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Queue* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1751, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this Dawn thisApi, Span<Queue> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueReference(this Dawn thisApi, Span<Queue> queue)
        {
            // SpanOverloader
            thisApi.QueueReference(ref queue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueRelease(this Dawn thisApi, Span<Queue> queue)
        {
            // SpanOverloader
            thisApi.QueueRelease(ref queue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleReference(this Dawn thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleReference(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleRelease(this Dawn thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleRelease(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1760, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDraw(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDraw(ref renderBundleEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1761, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexed(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexed(ref renderBundleEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(renderBundleEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, RenderBundleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1764, Column 30 in dawn-webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(renderBundleEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1765, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1766, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderPopDebugGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPopDebugGroup(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(renderBundleEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1768, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(renderBundleEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(renderBundleEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1770, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(renderBundleEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, RenderPipeline* pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1771, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this Dawn thisApi, RenderBundleEncoder* renderBundleEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(renderBundleEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1772, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderReference(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderReference(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderRelease(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderRelease(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderBeginOcclusionQuery(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginOcclusionQuery(ref renderPassEncoder.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1778, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDraw(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDraw(ref renderPassEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1779, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexed(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexed(ref renderPassEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1781, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1782, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderEnd(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEnd(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1783, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderEndOcclusionQuery(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndOcclusionQuery(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderEndPass(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndPass(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint bundleCount, RenderBundle** bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundleCount, bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1785, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint bundleCount, ref RenderBundle* bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundleCount, ref bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(renderPassEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1786, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1787, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderPopDebugGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPopDebugGroup(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(renderPassEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1788, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(renderPassEncoder, ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Color* color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1790, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(renderPassEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1791, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(renderPassEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(renderPassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, RenderPipeline* pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1793, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1794, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetScissorRect(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint x, uint y, uint width, uint height)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetScissorRect(ref renderPassEncoder.GetPinnableReference(), x, y, width, height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1795, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetStencilReference(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint reference)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetStencilReference(ref renderPassEncoder.GetPinnableReference(), reference);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(renderPassEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1797, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderSetViewport(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetViewport(ref renderPassEncoder.GetPinnableReference(), x, y, width, height, minDepth, maxDepth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(renderPassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(ref renderPassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(ref renderPassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderReference(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderReference(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderRelease(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderRelease(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 33 in dawn-webgpu.h")]
        public static unsafe BindGroupLayout* RenderPipelineGetBindGroupLayout(this Dawn thisApi, Span<RenderPipeline> renderPipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.RenderPipelineGetBindGroupLayout(ref renderPipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this Dawn thisApi, RenderPipeline* renderPipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(renderPipeline, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this Dawn thisApi, Span<RenderPipeline> renderPipeline, byte* label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this Dawn thisApi, Span<RenderPipeline> renderPipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this Dawn thisApi, Span<RenderPipeline> renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineReference(this Dawn thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineReference(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineRelease(this Dawn thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineRelease(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerSetLabel(this Dawn thisApi, Sampler* sampler, Span<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(sampler, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerSetLabel(this Dawn thisApi, Span<Sampler> sampler, byte* label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerSetLabel(this Dawn thisApi, Span<Sampler> sampler, Span<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerSetLabel(this Dawn thisApi, Span<Sampler> sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerReference(this Dawn thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerReference(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerRelease(this Dawn thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerRelease(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this Dawn thisApi, ShaderModule* shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(shaderModule, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo(this Dawn thisApi, Span<ShaderModule> shaderModule, PfnCompilationInfoCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1814, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this Dawn thisApi, Span<ShaderModule> shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this Dawn thisApi, ShaderModule* shaderModule, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(shaderModule, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this Dawn thisApi, Span<ShaderModule> shaderModule, byte* label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this Dawn thisApi, Span<ShaderModule> shaderModule, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1815, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this Dawn thisApi, Span<ShaderModule> shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleReference(this Dawn thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleReference(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleRelease(this Dawn thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleRelease(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        public static unsafe void SurfaceReference(this Dawn thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceReference(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        public static unsafe void SurfaceRelease(this Dawn thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceRelease(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainConfigure(this Dawn thisApi, Span<SwapChain> swapChain, TextureFormat format, uint allowedUsage, uint width, uint height)
        {
            // SpanOverloader
            thisApi.SwapChainConfigure(ref swapChain.GetPinnableReference(), format, allowedUsage, width, height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1825, Column 29 in dawn-webgpu.h")]
        public static unsafe TextureView* SwapChainGetCurrentTextureView(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            return thisApi.SwapChainGetCurrentTextureView(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainPresent(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainPresent(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainReference(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainReference(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainRelease(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainRelease(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this Dawn thisApi, Texture* texture, Span<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(texture, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this Dawn thisApi, Span<Texture> texture, TextureViewDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 29 in dawn-webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this Dawn thisApi, Span<Texture> texture, Span<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1832, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureDestroy(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureDestroy(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1833, Column 22 in dawn-webgpu.h")]
        public static unsafe uint TextureGetDepthOrArrayLayers(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDepthOrArrayLayers(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1834, Column 34 in dawn-webgpu.h")]
        public static unsafe TextureDimension TextureGetDimension(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDimension(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1835, Column 31 in dawn-webgpu.h")]
        public static unsafe TextureFormat TextureGetFormat(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetFormat(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1836, Column 22 in dawn-webgpu.h")]
        public static unsafe uint TextureGetHeight(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetHeight(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 22 in dawn-webgpu.h")]
        public static unsafe uint TextureGetMipLevelCount(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetMipLevelCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1838, Column 22 in dawn-webgpu.h")]
        public static unsafe uint TextureGetSampleCount(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetSampleCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1839, Column 30 in dawn-webgpu.h")]
        public static unsafe TextureUsage TextureGetUsage(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetUsage(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1840, Column 22 in dawn-webgpu.h")]
        public static unsafe uint TextureGetWidth(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetWidth(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureSetLabel(this Dawn thisApi, Texture* texture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(texture, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureSetLabel(this Dawn thisApi, Span<Texture> texture, byte* label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureSetLabel(this Dawn thisApi, Span<Texture> texture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1841, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureSetLabel(this Dawn thisApi, Span<Texture> texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureReference(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureReference(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureRelease(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureRelease(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewSetLabel(this Dawn thisApi, TextureView* textureView, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(textureView, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewSetLabel(this Dawn thisApi, Span<TextureView> textureView, byte* label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewSetLabel(this Dawn thisApi, Span<TextureView> textureView, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewSetLabel(this Dawn thisApi, Span<TextureView> textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewReference(this Dawn thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewReference(ref textureView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewRelease(this Dawn thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewRelease(ref textureView.GetPinnableReference());
        }

    }
}

