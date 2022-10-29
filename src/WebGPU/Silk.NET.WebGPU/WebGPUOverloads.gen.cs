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
        [NativeName("Src", "Line 1405, Column 26 in webgpu.h")]
        public static unsafe InstanceImpl* CreateInstance(this WebGPU thisApi, Span<InstanceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CreateInstance(ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, DeviceImpl* device, Span<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(device, ref procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<DeviceImpl> device, byte* procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<DeviceImpl> device, Span<byte> procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), ref procName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 22 in webgpu.h")]
        public static unsafe PfnProc GetProcAddress(this WebGPU thisApi, Span<DeviceImpl> device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(ref device.GetPinnableReference(), procName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, AdapterImpl* adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(adapter, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Span<AdapterImpl> adapter, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Span<AdapterImpl> adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(ref adapter.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        public static unsafe bool AdapterGetLimits(this WebGPU thisApi, AdapterImpl* adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(adapter, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        public static unsafe bool AdapterGetLimits(this WebGPU thisApi, Span<AdapterImpl> adapter, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1410, Column 18 in webgpu.h")]
        public static unsafe bool AdapterGetLimits(this WebGPU thisApi, Span<AdapterImpl> adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(ref adapter.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, AdapterImpl* adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(adapter, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Span<AdapterImpl> adapter, AdapterProperties* properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Span<AdapterImpl> adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(ref adapter.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1412, Column 18 in webgpu.h")]
        public static unsafe bool AdapterHasFeature(this WebGPU thisApi, Span<AdapterImpl> adapter, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.AdapterHasFeature(ref adapter.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, AdapterImpl* adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, AdapterImpl* adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, AdapterImpl* adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(adapter, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, Span<AdapterImpl> adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Span<AdapterImpl> adapter, DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice(this WebGPU thisApi, Span<AdapterImpl> adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1413, Column 18 in webgpu.h")]
        public static unsafe void AdapterRequestDevice<T0>(this WebGPU thisApi, Span<AdapterImpl> adapter, Span<DeviceDescriptor> descriptor, PfnRequestDeviceCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AdapterRequestDevice(ref adapter.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, BindGroupImpl* bindGroup, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(bindGroup, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroupImpl> bindGroup, byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroupImpl> bindGroup, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1416, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, Span<BindGroupImpl> bindGroup, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(ref bindGroup.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, BindGroupLayoutImpl* bindGroupLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(bindGroupLayout, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayoutImpl> bindGroupLayout, byte* label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayoutImpl> bindGroupLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1419, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, Span<BindGroupLayoutImpl> bindGroupLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(ref bindGroupLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1422, Column 18 in webgpu.h")]
        public static unsafe void BufferDestroy(this WebGPU thisApi, Span<BufferImpl> buffer)
        {
            // SpanOverloader
            thisApi.BufferDestroy(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1423, Column 26 in webgpu.h")]
        public static unsafe void* BufferGetConstMappedRange(this WebGPU thisApi, Span<BufferImpl> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetConstMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 20 in webgpu.h")]
        public static unsafe void* BufferGetMappedRange(this WebGPU thisApi, Span<BufferImpl> buffer, nuint offset, nuint size)
        {
            // SpanOverloader
            return thisApi.BufferGetMappedRange(ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 22 in webgpu.h")]
        public static unsafe ulong BufferGetSize(this WebGPU thisApi, Span<BufferImpl> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetSize(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1426, Column 29 in webgpu.h")]
        public static unsafe BufferUsage BufferGetUsage(this WebGPU thisApi, Span<BufferImpl> buffer)
        {
            // SpanOverloader
            return thisApi.BufferGetUsage(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this WebGPU thisApi, BufferImpl* buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(buffer, mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync(this WebGPU thisApi, Span<BufferImpl> buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this WebGPU thisApi, Span<BufferImpl> buffer, uint mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(ref buffer.GetPinnableReference(), mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, BufferImpl* buffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(buffer, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<BufferImpl> buffer, byte* label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<BufferImpl> buffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1428, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Span<BufferImpl> buffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(ref buffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1429, Column 18 in webgpu.h")]
        public static unsafe void BufferUnmap(this WebGPU thisApi, Span<BufferImpl> buffer)
        {
            // SpanOverloader
            thisApi.BufferUnmap(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, CommandBufferImpl* commandBuffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(commandBuffer, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBufferImpl> commandBuffer, byte* label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBufferImpl> commandBuffer, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, Span<CommandBufferImpl> commandBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(ref commandBuffer.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoderImpl* CommandEncoderBeginComputePass(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoderImpl* CommandEncoderBeginComputePass(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ComputePassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1435, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoderImpl* CommandEncoderBeginComputePass(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoderImpl* CommandEncoderBeginRenderPass(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoderImpl* CommandEncoderBeginRenderPass(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, RenderPassDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1436, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoderImpl* CommandEncoderBeginRenderPass(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(commandEncoder, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, BufferImpl* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderClearBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderClearBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, BufferImpl* source, ulong sourceOffset, Span<BufferImpl> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<BufferImpl> source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<BufferImpl> source, ulong sourceOffset, Span<BufferImpl> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(commandEncoder, ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, BufferImpl* source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, BufferImpl* source, ulong sourceOffset, Span<BufferImpl> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), source, sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<BufferImpl> source, ulong sourceOffset, BufferImpl* destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, destination, destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<BufferImpl> source, ulong sourceOffset, Span<BufferImpl> destination, ulong destinationOffset, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), sourceOffset, ref destination.GetPinnableReference(), destinationOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyBuffer* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyBuffer* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyBuffer> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1439, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyBuffer> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, ImageCopyBuffer* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1440, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyBuffer> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, ImageCopyTexture* source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), source, ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, ImageCopyTexture* destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), destination, ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1441, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<ImageCopyTexture> source, Span<ImageCopyTexture> destination, Span<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(ref commandEncoder.GetPinnableReference(), ref source.GetPinnableReference(), ref destination.GetPinnableReference(), ref copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        public static unsafe CommandBufferImpl* CommandEncoderFinish(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(commandEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        public static unsafe CommandBufferImpl* CommandEncoderFinish(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, CommandBufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 31 in webgpu.h")]
        public static unsafe CommandBufferImpl* CommandEncoderFinish(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(ref commandEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(commandEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(ref commandEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1444, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPopDebugGroup(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderPopDebugGroup(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(commandEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1445, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(ref commandEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, Span<BufferImpl> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<QuerySetImpl> querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<QuerySetImpl> querySet, uint firstQuery, uint queryCount, Span<BufferImpl> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(commandEncoder, ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, QuerySetImpl* querySet, uint firstQuery, uint queryCount, Span<BufferImpl> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), querySet, firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<QuerySetImpl> querySet, uint firstQuery, uint queryCount, BufferImpl* destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, destination, destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1446, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderResolveQuerySet(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<QuerySetImpl> querySet, uint firstQuery, uint queryCount, Span<BufferImpl> destination, ulong destinationOffset)
        {
            // SpanOverloader
            thisApi.CommandEncoderResolveQuerySet(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), firstQuery, queryCount, ref destination.GetPinnableReference(), destinationOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(commandEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(ref commandEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, CommandEncoderImpl* commandEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(commandEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, QuerySetImpl* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderWriteTimestamp(this WebGPU thisApi, Span<CommandEncoderImpl> commandEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteTimestamp(ref commandEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(computePassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, QuerySetImpl* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderBeginPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1452, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroups(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroups(ref computePassEncoder.GetPinnableReference(), workgroupCountX, workgroupCountY, workgroupCountZ);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(computePassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchWorkgroupsIndirect(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchWorkgroupsIndirect(ref computePassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderEnd(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEnd(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1455, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderEndPipelineStatisticsQuery(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEndPipelineStatisticsQuery(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(computePassEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(ref computePassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1457, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPopDebugGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPopDebugGroup(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(computePassEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(ref computePassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1459, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(ref computePassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(computePassEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(ref computePassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, ComputePassEncoderImpl* computePassEncoder, Span<ComputePipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(computePassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, ComputePipelineImpl* pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetPipeline(this WebGPU thisApi, Span<ComputePassEncoderImpl> computePassEncoder, Span<ComputePipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPipeline(ref computePassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1464, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayoutImpl* ComputePipelineGetBindGroupLayout(this WebGPU thisApi, Span<ComputePipelineImpl> computePipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.ComputePipelineGetBindGroupLayout(ref computePipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, ComputePipelineImpl* computePipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(computePipeline, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipelineImpl> computePipeline, byte* label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipelineImpl> computePipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1465, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, Span<ComputePipelineImpl> computePipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(ref computePipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        public static unsafe BindGroupImpl* DeviceCreateBindGroup(this WebGPU thisApi, DeviceImpl* device, Span<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        public static unsafe BindGroupImpl* DeviceCreateBindGroup(this WebGPU thisApi, Span<DeviceImpl> device, BindGroupDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 27 in webgpu.h")]
        public static unsafe BindGroupImpl* DeviceCreateBindGroup(this WebGPU thisApi, Span<DeviceImpl> device, Span<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayoutImpl* DeviceCreateBindGroupLayout(this WebGPU thisApi, DeviceImpl* device, Span<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayoutImpl* DeviceCreateBindGroupLayout(this WebGPU thisApi, Span<DeviceImpl> device, BindGroupLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayoutImpl* DeviceCreateBindGroupLayout(this WebGPU thisApi, Span<DeviceImpl> device, Span<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        public static unsafe BufferImpl* DeviceCreateBuffer(this WebGPU thisApi, DeviceImpl* device, Span<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        public static unsafe BufferImpl* DeviceCreateBuffer(this WebGPU thisApi, Span<DeviceImpl> device, BufferDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1470, Column 24 in webgpu.h")]
        public static unsafe BufferImpl* DeviceCreateBuffer(this WebGPU thisApi, Span<DeviceImpl> device, Span<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        public static unsafe CommandEncoderImpl* DeviceCreateCommandEncoder(this WebGPU thisApi, DeviceImpl* device, Span<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        public static unsafe CommandEncoderImpl* DeviceCreateCommandEncoder(this WebGPU thisApi, Span<DeviceImpl> device, CommandEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 32 in webgpu.h")]
        public static unsafe CommandEncoderImpl* DeviceCreateCommandEncoder(this WebGPU thisApi, Span<DeviceImpl> device, Span<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        public static unsafe ComputePipelineImpl* DeviceCreateComputePipeline(this WebGPU thisApi, DeviceImpl* device, Span<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        public static unsafe ComputePipelineImpl* DeviceCreateComputePipeline(this WebGPU thisApi, Span<DeviceImpl> device, ComputePipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 33 in webgpu.h")]
        public static unsafe ComputePipelineImpl* DeviceCreateComputePipeline(this WebGPU thisApi, Span<DeviceImpl> device, Span<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, DeviceImpl* device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, DeviceImpl* device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, DeviceImpl* device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(device, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, Span<DeviceImpl> device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Span<DeviceImpl> device, ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync(this WebGPU thisApi, Span<DeviceImpl> device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateComputePipelineAsync<T0>(this WebGPU thisApi, Span<DeviceImpl> device, Span<ComputePipelineDescriptor> descriptor, PfnCreateComputePipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateComputePipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        public static unsafe PipelineLayoutImpl* DeviceCreatePipelineLayout(this WebGPU thisApi, DeviceImpl* device, Span<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        public static unsafe PipelineLayoutImpl* DeviceCreatePipelineLayout(this WebGPU thisApi, Span<DeviceImpl> device, PipelineLayoutDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 32 in webgpu.h")]
        public static unsafe PipelineLayoutImpl* DeviceCreatePipelineLayout(this WebGPU thisApi, Span<DeviceImpl> device, Span<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        public static unsafe QuerySetImpl* DeviceCreateQuerySet(this WebGPU thisApi, DeviceImpl* device, Span<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        public static unsafe QuerySetImpl* DeviceCreateQuerySet(this WebGPU thisApi, Span<DeviceImpl> device, QuerySetDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 26 in webgpu.h")]
        public static unsafe QuerySetImpl* DeviceCreateQuerySet(this WebGPU thisApi, Span<DeviceImpl> device, Span<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, DeviceImpl* device, Span<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Span<DeviceImpl> device, RenderBundleEncoderDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1476, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoderImpl* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Span<DeviceImpl> device, Span<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        public static unsafe RenderPipelineImpl* DeviceCreateRenderPipeline(this WebGPU thisApi, DeviceImpl* device, Span<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        public static unsafe RenderPipelineImpl* DeviceCreateRenderPipeline(this WebGPU thisApi, Span<DeviceImpl> device, RenderPipelineDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 32 in webgpu.h")]
        public static unsafe RenderPipelineImpl* DeviceCreateRenderPipeline(this WebGPU thisApi, Span<DeviceImpl> device, Span<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, DeviceImpl* device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, DeviceImpl* device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, DeviceImpl* device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(device, ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Span<DeviceImpl> device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Span<DeviceImpl> device, RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), descriptor, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Span<DeviceImpl> device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1478, Column 18 in webgpu.h")]
        public static unsafe void DeviceCreateRenderPipelineAsync<T0>(this WebGPU thisApi, Span<DeviceImpl> device, Span<RenderPipelineDescriptor> descriptor, PfnCreateRenderPipelineAsyncCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceCreateRenderPipelineAsync(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        public static unsafe SamplerImpl* DeviceCreateSampler(this WebGPU thisApi, DeviceImpl* device, Span<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        public static unsafe SamplerImpl* DeviceCreateSampler(this WebGPU thisApi, Span<DeviceImpl> device, SamplerDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1479, Column 25 in webgpu.h")]
        public static unsafe SamplerImpl* DeviceCreateSampler(this WebGPU thisApi, Span<DeviceImpl> device, Span<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        public static unsafe ShaderModuleImpl* DeviceCreateShaderModule(this WebGPU thisApi, DeviceImpl* device, Span<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        public static unsafe ShaderModuleImpl* DeviceCreateShaderModule(this WebGPU thisApi, Span<DeviceImpl> device, ShaderModuleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 30 in webgpu.h")]
        public static unsafe ShaderModuleImpl* DeviceCreateShaderModule(this WebGPU thisApi, Span<DeviceImpl> device, Span<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, DeviceImpl* device, SurfaceImpl* surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, DeviceImpl* device, Span<SurfaceImpl> surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, DeviceImpl* device, Span<SurfaceImpl> surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, ref surface.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, Span<DeviceImpl> device, SurfaceImpl* surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, Span<DeviceImpl> device, SurfaceImpl* surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), surface, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, Span<DeviceImpl> device, Span<SurfaceImpl> surface, SwapChainDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 27 in webgpu.h")]
        public static unsafe SwapChainImpl* DeviceCreateSwapChain(this WebGPU thisApi, Span<DeviceImpl> device, Span<SurfaceImpl> surface, Span<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(ref device.GetPinnableReference(), ref surface.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        public static unsafe TextureImpl* DeviceCreateTexture(this WebGPU thisApi, DeviceImpl* device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(device, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        public static unsafe TextureImpl* DeviceCreateTexture(this WebGPU thisApi, Span<DeviceImpl> device, TextureDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 25 in webgpu.h")]
        public static unsafe TextureImpl* DeviceCreateTexture(this WebGPU thisApi, Span<DeviceImpl> device, Span<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(ref device.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 18 in webgpu.h")]
        public static unsafe void DeviceDestroy(this WebGPU thisApi, Span<DeviceImpl> device)
        {
            // SpanOverloader
            thisApi.DeviceDestroy(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, DeviceImpl* device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(device, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Span<DeviceImpl> device, FeatureName* features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Span<DeviceImpl> device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(ref device.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        public static unsafe bool DeviceGetLimits(this WebGPU thisApi, DeviceImpl* device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(device, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        public static unsafe bool DeviceGetLimits(this WebGPU thisApi, Span<DeviceImpl> device, SupportedLimits* limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), limits);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 18 in webgpu.h")]
        public static unsafe bool DeviceGetLimits(this WebGPU thisApi, Span<DeviceImpl> device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(ref device.GetPinnableReference(), ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 23 in webgpu.h")]
        public static unsafe QueueImpl* DeviceGetQueue(this WebGPU thisApi, Span<DeviceImpl> device)
        {
            // SpanOverloader
            return thisApi.DeviceGetQueue(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 18 in webgpu.h")]
        public static unsafe bool DeviceHasFeature(this WebGPU thisApi, Span<DeviceImpl> device, FeatureName feature)
        {
            // SpanOverloader
            return thisApi.DeviceHasFeature(ref device.GetPinnableReference(), feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe bool DevicePopErrorScope<T0>(this WebGPU thisApi, DeviceImpl* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe bool DevicePopErrorScope(this WebGPU thisApi, Span<DeviceImpl> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1488, Column 18 in webgpu.h")]
        public static unsafe bool DevicePopErrorScope<T0>(this WebGPU thisApi, Span<DeviceImpl> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1489, Column 18 in webgpu.h")]
        public static unsafe void DevicePushErrorScope(this WebGPU thisApi, Span<DeviceImpl> device, ErrorFilter filter)
        {
            // SpanOverloader
            thisApi.DevicePushErrorScope(ref device.GetPinnableReference(), filter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this WebGPU thisApi, DeviceImpl* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback(this WebGPU thisApi, Span<DeviceImpl> device, PfnDeviceLostCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this WebGPU thisApi, Span<DeviceImpl> device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, DeviceImpl* device, Span<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(device, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<DeviceImpl> device, byte* label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<DeviceImpl> device, Span<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Span<DeviceImpl> device, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(ref device.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this WebGPU thisApi, DeviceImpl* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback(this WebGPU thisApi, Span<DeviceImpl> device, PfnErrorCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this WebGPU thisApi, Span<DeviceImpl> device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        public static unsafe SurfaceImpl* InstanceCreateSurface(this WebGPU thisApi, InstanceImpl* instance, Span<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(instance, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        public static unsafe SurfaceImpl* InstanceCreateSurface(this WebGPU thisApi, Span<InstanceImpl> instance, SurfaceDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 25 in webgpu.h")]
        public static unsafe SurfaceImpl* InstanceCreateSurface(this WebGPU thisApi, Span<InstanceImpl> instance, Span<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(ref instance.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 18 in webgpu.h")]
        public static unsafe void InstanceProcessEvents(this WebGPU thisApi, Span<InstanceImpl> instance)
        {
            // SpanOverloader
            thisApi.InstanceProcessEvents(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, InstanceImpl* instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, InstanceImpl* instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, ref options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, InstanceImpl* instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(instance, ref options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, Span<InstanceImpl> instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Span<InstanceImpl> instance, RequestAdapterOptions* options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), options, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter(this WebGPU thisApi, Span<InstanceImpl> instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), ref options.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in webgpu.h")]
        public static unsafe void InstanceRequestAdapter<T0>(this WebGPU thisApi, Span<InstanceImpl> instance, Span<RequestAdapterOptions> options, PfnRequestAdapterCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.InstanceRequestAdapter(ref instance.GetPinnableReference(), ref options.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, PipelineLayoutImpl* pipelineLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(pipelineLayout, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayoutImpl> pipelineLayout, byte* label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayoutImpl> pipelineLayout, Span<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, Span<PipelineLayoutImpl> pipelineLayout, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(ref pipelineLayout.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        public static unsafe void QuerySetDestroy(this WebGPU thisApi, Span<QuerySetImpl> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetDestroy(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1504, Column 22 in webgpu.h")]
        public static unsafe uint QuerySetGetCount(this WebGPU thisApi, Span<QuerySetImpl> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetCount(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 27 in webgpu.h")]
        public static unsafe QueryType QuerySetGetType(this WebGPU thisApi, Span<QuerySetImpl> querySet)
        {
            // SpanOverloader
            return thisApi.QuerySetGetType(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, QuerySetImpl* querySet, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(querySet, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySetImpl> querySet, byte* label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySetImpl> querySet, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, Span<QuerySetImpl> querySet, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(ref querySet.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this WebGPU thisApi, QueueImpl* queue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(queue, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone(this WebGPU thisApi, Span<QueueImpl> queue, PfnQueueWorkDoneCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1509, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this WebGPU thisApi, Span<QueueImpl> queue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(ref queue.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, QueueImpl* queue, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(queue, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<QueueImpl> queue, byte* label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<QueueImpl> queue, Span<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Span<QueueImpl> queue, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(ref queue.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        public static unsafe void QueueSubmit(this WebGPU thisApi, Span<QueueImpl> queue, uint commandCount, CommandBufferImpl** commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1511, Column 18 in webgpu.h")]
        public static unsafe void QueueSubmit(this WebGPU thisApi, Span<QueueImpl> queue, uint commandCount, ref CommandBufferImpl* commands)
        {
            // SpanOverloader
            thisApi.QueueSubmit(ref queue.GetPinnableReference(), commandCount, ref commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, QueueImpl* queue, BufferImpl* buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, QueueImpl* queue, Span<BufferImpl> buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, QueueImpl* queue, Span<BufferImpl> buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, Span<QueueImpl> queue, BufferImpl* buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Span<QueueImpl> queue, BufferImpl* buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), buffer, bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer(this WebGPU thisApi, Span<QueueImpl> queue, Span<BufferImpl> buffer, ulong bufferOffset, void* data, nuint size)
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1512, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Span<QueueImpl> queue, Span<BufferImpl> buffer, ulong bufferOffset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(ref queue.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, QueueImpl* queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, ImageCopyTexture* destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), destination, ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, void* data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), data, dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, TextureDataLayout* dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, dataLayout, ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Span<QueueImpl> queue, Span<ImageCopyTexture> destination, Span<T0> data, nuint dataSize, Span<TextureDataLayout> dataLayout, Span<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(ref queue.GetPinnableReference(), ref destination.GetPinnableReference(), ref data.GetPinnableReference(), dataSize, ref dataLayout.GetPinnableReference(), ref writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1516, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDraw(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDraw(ref renderBundleEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1517, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexed(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexed(ref renderBundleEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1518, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndexedIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(renderBundleEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, BufferImpl* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1519, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderDrawIndirect(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrawIndirect(ref renderBundleEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        public static unsafe RenderBundleImpl* RenderBundleEncoderFinish(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(renderBundleEncoder, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        public static unsafe RenderBundleImpl* RenderBundleEncoderFinish(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, RenderBundleDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 30 in webgpu.h")]
        public static unsafe RenderBundleImpl* RenderBundleEncoderFinish(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(ref renderBundleEncoder.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(renderBundleEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(ref renderBundleEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPopDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPopDebugGroup(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(renderBundleEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1523, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(ref renderBundleEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(ref renderBundleEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<BufferImpl> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(renderBundleEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<BufferImpl> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetIndexBuffer(ref renderBundleEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(renderBundleEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1526, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(ref renderBundleEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, Span<RenderPipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(renderBundleEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, RenderPipelineImpl* pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetPipeline(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, Span<RenderPipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPipeline(ref renderBundleEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, RenderBundleEncoderImpl* renderBundleEncoder, uint slot, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(renderBundleEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderBundleEncoderImpl> renderBundleEncoder, uint slot, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetVertexBuffer(ref renderBundleEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1531, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginOcclusionQuery(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginOcclusionQuery(ref renderPassEncoder.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(renderPassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, QuerySetImpl* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1532, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderBeginPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<QuerySetImpl> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderBeginPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1533, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDraw(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDraw(ref renderPassEncoder.GetPinnableReference(), vertexCount, instanceCount, firstVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1534, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexed(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexed(ref renderPassEncoder.GetPinnableReference(), indexCount, instanceCount, firstIndex, baseVertex, firstInstance);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndexedIndirect(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndexedIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(renderPassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, BufferImpl* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderDrawIndirect(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<BufferImpl> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrawIndirect(ref renderPassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1537, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEnd(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEnd(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEndOcclusionQuery(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndOcclusionQuery(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderEndPipelineStatisticsQuery(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndPipelineStatisticsQuery(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint bundlesCount, RenderBundleImpl** bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundlesCount, bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1540, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderExecuteBundles(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint bundlesCount, ref RenderBundleImpl* bundles)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderExecuteBundles(ref renderPassEncoder.GetPinnableReference(), bundlesCount, ref bundles);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(renderPassEncoder, ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, byte* markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), ref markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(ref renderPassEncoder.GetPinnableReference(), markerLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1542, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPopDebugGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPopDebugGroup(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(renderPassEncoder, ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, byte* groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), ref groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(ref renderPassEncoder.GetPinnableReference(), groupLabel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint groupIndex, BindGroupImpl* group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, group, dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, dynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint groupIndex, Span<BindGroupImpl> group, uint dynamicOffsetCount, Span<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(ref renderPassEncoder.GetPinnableReference(), groupIndex, ref group.GetPinnableReference(), dynamicOffsetCount, ref dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(renderPassEncoder, ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Color* color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1545, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(ref renderPassEncoder.GetPinnableReference(), ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<BufferImpl> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(renderPassEncoder, ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, BufferImpl* buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), buffer, format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1546, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetIndexBuffer(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<BufferImpl> buffer, IndexFormat format, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetIndexBuffer(ref renderPassEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), format, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(renderPassEncoder, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, byte* label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1547, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(ref renderPassEncoder.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, Span<RenderPipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(renderPassEncoder, ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, RenderPipelineImpl* pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), pipeline);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1548, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetPipeline(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, Span<RenderPipelineImpl> pipeline)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPipeline(ref renderPassEncoder.GetPinnableReference(), ref pipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1549, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetScissorRect(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint x, uint y, uint width, uint height)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetScissorRect(ref renderPassEncoder.GetPinnableReference(), x, y, width, height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetStencilReference(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint reference)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetStencilReference(ref renderPassEncoder.GetPinnableReference(), reference);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, RenderPassEncoderImpl* renderPassEncoder, uint slot, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(renderPassEncoder, slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint slot, BufferImpl* buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, buffer, offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1551, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetVertexBuffer(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, uint slot, Span<BufferImpl> buffer, ulong offset, ulong size)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetVertexBuffer(ref renderPassEncoder.GetPinnableReference(), slot, ref buffer.GetPinnableReference(), offset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1552, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetViewport(this WebGPU thisApi, Span<RenderPassEncoderImpl> renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetViewport(ref renderPassEncoder.GetPinnableReference(), x, y, width, height, minDepth, maxDepth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayoutImpl* RenderPipelineGetBindGroupLayout(this WebGPU thisApi, Span<RenderPipelineImpl> renderPipeline, uint groupIndex)
        {
            // SpanOverloader
            return thisApi.RenderPipelineGetBindGroupLayout(ref renderPipeline.GetPinnableReference(), groupIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, RenderPipelineImpl* renderPipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(renderPipeline, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipelineImpl> renderPipeline, byte* label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipelineImpl> renderPipeline, Span<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, Span<RenderPipelineImpl> renderPipeline, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(ref renderPipeline.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, SamplerImpl* sampler, Span<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(sampler, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<SamplerImpl> sampler, byte* label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<SamplerImpl> sampler, Span<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Span<SamplerImpl> sampler, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(ref sampler.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this WebGPU thisApi, ShaderModuleImpl* shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(shaderModule, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo(this WebGPU thisApi, Span<ShaderModuleImpl> shaderModule, PfnCompilationInfoCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this WebGPU thisApi, Span<ShaderModuleImpl> shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(ref shaderModule.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, ShaderModuleImpl* shaderModule, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(shaderModule, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModuleImpl> shaderModule, byte* label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModuleImpl> shaderModule, Span<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1563, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, Span<ShaderModuleImpl> shaderModule, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(ref shaderModule.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, SurfaceImpl* surface, Span<AdapterImpl> adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(surface, ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, Span<SurfaceImpl> surface, AdapterImpl* adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(ref surface.GetPinnableReference(), adapter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1566, Column 31 in webgpu.h")]
        public static unsafe TextureFormat SurfaceGetPreferredFormat(this WebGPU thisApi, Span<SurfaceImpl> surface, Span<AdapterImpl> adapter)
        {
            // SpanOverloader
            return thisApi.SurfaceGetPreferredFormat(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 29 in webgpu.h")]
        public static unsafe TextureViewImpl* SwapChainGetCurrentTextureView(this WebGPU thisApi, Span<SwapChainImpl> swapChain)
        {
            // SpanOverloader
            return thisApi.SwapChainGetCurrentTextureView(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1570, Column 18 in webgpu.h")]
        public static unsafe void SwapChainPresent(this WebGPU thisApi, Span<SwapChainImpl> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainPresent(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        public static unsafe TextureViewImpl* TextureCreateView(this WebGPU thisApi, TextureImpl* texture, Span<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(texture, ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        public static unsafe TextureViewImpl* TextureCreateView(this WebGPU thisApi, Span<TextureImpl> texture, TextureViewDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1573, Column 29 in webgpu.h")]
        public static unsafe TextureViewImpl* TextureCreateView(this WebGPU thisApi, Span<TextureImpl> texture, Span<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(ref texture.GetPinnableReference(), ref descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void TextureDestroy(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            thisApi.TextureDestroy(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetDepthOrArrayLayers(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDepthOrArrayLayers(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1576, Column 34 in webgpu.h")]
        public static unsafe TextureDimension TextureGetDimension(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetDimension(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 31 in webgpu.h")]
        public static unsafe TextureFormat TextureGetFormat(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetFormat(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetHeight(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetHeight(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1579, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetMipLevelCount(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetMipLevelCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1580, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetSampleCount(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetSampleCount(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 30 in webgpu.h")]
        public static unsafe TextureUsage TextureGetUsage(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetUsage(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 22 in webgpu.h")]
        public static unsafe uint TextureGetWidth(this WebGPU thisApi, Span<TextureImpl> texture)
        {
            // SpanOverloader
            return thisApi.TextureGetWidth(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, TextureImpl* texture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(texture, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<TextureImpl> texture, byte* label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<TextureImpl> texture, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1583, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Span<TextureImpl> texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(ref texture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, TextureViewImpl* textureView, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(textureView, ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureViewImpl> textureView, byte* label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureViewImpl> textureView, Span<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), ref label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, Span<TextureViewImpl> textureView, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(ref textureView.GetPinnableReference(), label);
        }

    }
}

