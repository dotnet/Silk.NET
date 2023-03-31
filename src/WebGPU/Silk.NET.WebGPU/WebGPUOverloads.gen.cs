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
    public static class WebGPUOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 26 in webgpu.h")]
        public static unsafe Instance* CreateInstance(this WebGPU thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(device, in procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), in procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1420, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Adapter* adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(adapter, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Span<Adapter> adapter, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Span<Adapter> adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterGetLimits(this WebGPU thisApi, Adapter* adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(adapter, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterGetLimits(this WebGPU thisApi, Span<Adapter> adapter, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterGetLimits(this WebGPU thisApi, Span<Adapter> adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Adapter* adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(adapter, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Span<Adapter> adapter, AdapterProperties* properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Span<Adapter> adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterHasFeature(this WebGPU thisApi, Span<Adapter> adapter, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.AdapterHasFeature(ref adapter.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, Span<Adapter> adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Span<Adapter> adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, Span<Adapter> adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Span<Adapter> adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(bindGroup, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroup> bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroup> bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroup> bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(bindGroupLayout, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayout> bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayout> bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayout> bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 18 in webgpu.h")]
        public static unsafe void BufferDestroy(this WebGPU thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferDestroy(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 26 in webgpu.h")]
        public static unsafe void* BufferGetConstMappedRange(this WebGPU thisApi, Span<Buffer> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetConstMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 32 in webgpu.h")]
        public static unsafe BufferMapState BufferGetMapState(this WebGPU thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetMapState(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 20 in webgpu.h")]
        public static unsafe void* BufferGetMappedRange(this WebGPU thisApi, Span<Buffer> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 22 in webgpu.h")]
        public static unsafe ulong BufferGetSize(this WebGPU thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetSize(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 29 in webgpu.h")]
        public static unsafe BufferUsage BufferGetUsage(this WebGPU thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetUsage(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this WebGPU thisApi, Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(buffer, mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync(this WebGPU thisApi, Span<Buffer> buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this WebGPU thisApi, Span<Buffer> buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(buffer, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        public static unsafe void BufferUnmap(this WebGPU thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferUnmap(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(commandBuffer, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBuffer> commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBuffer> commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBuffer> commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(commandEncoder, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, Buffer* source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<Buffer> source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<Buffer> source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Buffer* source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Buffer* source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> source, ulong sourceOffset, Buffer* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> source, ulong sourceOffset, Span<Buffer> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyBuffer> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(commandEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPopDebugGroup(this WebGPU thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderPopDebugGroup(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(commandEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoder* commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Buffer* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint firstQuery, uint queryCount, Span<Buffer> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(commandEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1463, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, CommandEncoder* commandEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(commandEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1463, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1463, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, Span<CommandEncoder> commandEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1466, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(computePassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1466, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1466, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroups(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroups(ref computePassEncoder.GetPinnableReference(), workgroupCountX, workgroupCountY, workgroupCountZ);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(computePassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderEnd(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEnd(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderEndPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEndPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(computePassEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPopDebugGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPopDebugGroup(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(computePassEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(computePassEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, Span<ComputePipeline> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(computePassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, ComputePipeline* pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, Span<ComputePassEncoder> computePassEncoder, Span<ComputePipeline> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* ComputePipelineGetBindGroupLayout(this WebGPU thisApi, Span<ComputePipeline> computePipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.ComputePipelineGetBindGroupLayout(ref computePipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(computePipeline, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipeline> computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipeline> computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipeline> computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BindGroupLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QuerySetDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1493, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), in descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Device* device, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Device* device, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Span<Device> device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Span<Device> device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Span<Device> device, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Span<Device> device, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1498, Column 18 in webgpu.h")]
        public static unsafe void DeviceDestroy(this WebGPU thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceDestroy(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Device* device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(device, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Span<Device> device, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Span<Device> device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DeviceGetLimits(this WebGPU thisApi, Device* device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(device, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DeviceGetLimits(this WebGPU thisApi, Span<Device> device, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DeviceGetLimits(this WebGPU thisApi, Span<Device> device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1501, Column 23 in webgpu.h")]
        public static unsafe Queue* DeviceGetQueue(this WebGPU thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceGetQueue(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1502, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DeviceHasFeature(this WebGPU thisApi, Span<Device> device, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.DeviceHasFeature(ref device.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePopErrorScope<T0>(this WebGPU thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePopErrorScope(this WebGPU thisApi, Span<Device> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePopErrorScope<T0>(this WebGPU thisApi, Span<Device> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 18 in webgpu.h")]
        public static unsafe void DevicePushErrorScope(this WebGPU thisApi, Span<Device> device, ErrorFilter filter)
        {
            // SpanOverloader
            thisApi.DevicePushErrorScope(ref device.GetPinnableReference(), filter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this WebGPU thisApi, Device* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback(this WebGPU thisApi, Span<Device> device, PfnDeviceLostCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this WebGPU thisApi, Span<Device> device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(device, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<Device> device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this WebGPU thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback(this WebGPU thisApi, Span<Device> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this WebGPU thisApi, Span<Device> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(instance, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SurfaceDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        public static unsafe void InstanceProcessEvents(this WebGPU thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceProcessEvents(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, in options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, in options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), in options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Span<Instance> instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), in options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(pipelineLayout, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayout> pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayout> pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayout> pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        public static unsafe void QuerySetDestroy(this WebGPU thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetDestroy(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 22 in webgpu.h")]
        public static unsafe uint QuerySetGetCount(this WebGPU thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetCount(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 27 in webgpu.h")]
        public static unsafe QueryType QuerySetGetType(this WebGPU thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetType(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(querySet, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySet> querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySet> querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySet> querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this WebGPU thisApi, Queue* queue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(queue, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone(this WebGPU thisApi, Span<Queue> queue, PfnQueueWorkDoneCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this WebGPU thisApi, Span<Queue> queue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(queue, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void QueueSubmit(this WebGPU thisApi, Span<Queue> queue, uint commandCount, CommandBuffer** commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void QueueSubmit(this WebGPU thisApi, Span<Queue> queue, uint commandCount, ref CommandBuffer* commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, ref commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, Queue* queue, Span<Buffer> buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Queue* queue, Span<Buffer> buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, Span<Queue> queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Span<Queue> queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, Span<Queue> queue, Span<Buffer> buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Span<Queue> queue, Span<Buffer> buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<Queue> queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDataLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDraw(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDraw(ref renderBundleEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexed(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexed(ref renderBundleEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(renderBundleEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderBundleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(renderBundleEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPopDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPopDebugGroup(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(renderBundleEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(renderBundleEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(renderBundleEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(renderBundleEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, RenderPipeline* pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(renderBundleEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint slot, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderBundleEncoder> renderBundleEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginOcclusionQuery(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginOcclusionQuery(ref renderPassEncoder.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(renderPassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDraw(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDraw(ref renderPassEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexed(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexed(ref renderPassEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEnd(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEnd(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1553, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEndOcclusionQuery(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndOcclusionQuery(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1554, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEndPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint bundleCount, RenderBundle** bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundleCount, bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint bundleCount, ref RenderBundle* bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundleCount, ref bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(renderPassEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1557, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPopDebugGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPopDebugGroup(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(renderPassEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint groupIndex, Span<BindGroup> group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(renderPassEncoder, in color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), in color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1561, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(renderPassEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1561, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Buffer* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1561, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<Buffer> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(renderPassEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(renderPassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, RenderPipeline* pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<RenderPipeline> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1564, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetScissorRect(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint x, uint y, uint width, uint height)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetScissorRect(ref renderPassEncoder.GetPinnableReference(), x, y, width, height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetStencilReference(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint reference)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetStencilReference(ref renderPassEncoder.GetPinnableReference(), reference);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(renderPassEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint slot, Buffer* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, uint slot, Span<Buffer> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1567, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetViewport(this WebGPU thisApi, Span<RenderPassEncoder> renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetViewport(ref renderPassEncoder.GetPinnableReference(), x, y, width, height, minDepth, maxDepth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* RenderPipelineGetBindGroupLayout(this WebGPU thisApi, Span<RenderPipeline> renderPipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.RenderPipelineGetBindGroupLayout(ref renderPipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(renderPipeline, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipeline> renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipeline> renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipeline> renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(sampler, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<Sampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<Sampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<Sampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this WebGPU thisApi, ShaderModule* shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(shaderModule, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo(this WebGPU thisApi, Span<ShaderModule> shaderModule, PfnCompilationInfoCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this WebGPU thisApi, Span<ShaderModule> shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(shaderModule, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModule> shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModule> shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModule> shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, Surface* surface, Span<Adapter> adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(surface, ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, Span<Surface> surface, Adapter* adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(ref surface.GetPinnableReference(), adapter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, Span<Surface> surface, Span<Adapter> adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1584, Column 29 in webgpu.h")]
        public static unsafe TextureView* SwapChainGetCurrentTextureView(this WebGPU thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            return thisApi.SwapChainGetCurrentTextureView(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1585, Column 18 in webgpu.h")]
        public static unsafe void SwapChainPresent(this WebGPU thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainPresent(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this WebGPU thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(texture, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this WebGPU thisApi, Span<Texture> texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureViewDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this WebGPU thisApi, Span<Texture> texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1589, Column 18 in webgpu.h")]
        public static unsafe void TextureDestroy(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureDestroy(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetDepthOrArrayLayers(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDepthOrArrayLayers(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1591, Column 34 in webgpu.h")]
        public static unsafe TextureDimension TextureGetDimension(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDimension(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1592, Column 31 in webgpu.h")]
        public static unsafe TextureFormat TextureGetFormat(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetFormat(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1593, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetHeight(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetHeight(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1594, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetMipLevelCount(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetMipLevelCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetSampleCount(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetSampleCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1596, Column 30 in webgpu.h")]
        public static unsafe TextureUsage TextureGetUsage(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetUsage(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetWidth(this WebGPU thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetWidth(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(texture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<Texture> texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<Texture> texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<Texture> texture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(textureView, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureView> textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureView> textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureView> textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

    }
}

