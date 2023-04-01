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
        [NativeName("Src", "Line 1423, Column 20 in webgpu.h")]
        public static unsafe nuint AdapterEnumerateFeatures(this WebGPU thisApi, Adapter* adapter, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.AdapterEnumerateFeatures(adapter, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 AdapterGetLimits(this WebGPU thisApi, Adapter* adapter, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(adapter, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1425, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetProperties(this WebGPU thisApi, Adapter* adapter, Span<AdapterProperties> properties)
        {
            // SpanOverloader
            thisApi.AdapterGetProperties(adapter, ref properties.GetPinnableReference());
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
        [NativeName("Src", "Line 1430, Column 18 in webgpu.h")]
        public static unsafe void BindGroupSetLabel(this WebGPU thisApi, BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupSetLabel(bindGroup, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1433, Column 18 in webgpu.h")]
        public static unsafe void BindGroupLayoutSetLabel(this WebGPU thisApi, BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutSetLabel(bindGroupLayout, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1442, Column 18 in webgpu.h")]
        public static unsafe void BufferMapAsync<T0>(this WebGPU thisApi, Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferMapAsync(buffer, mode, offset, size, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1443, Column 18 in webgpu.h")]
        public static unsafe void BufferSetLabel(this WebGPU thisApi, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.BufferSetLabel(buffer, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1447, Column 18 in webgpu.h")]
        public static unsafe void CommandBufferSetLabel(this WebGPU thisApi, CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandBufferSetLabel(commandBuffer, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(commandEncoder, in descriptor.GetPinnableReference());
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
        [NativeName("Src", "Line 1457, Column 31 in webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1458, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderInsertDebugMarker(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderInsertDebugMarker(commandEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1460, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderPushDebugGroup(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.CommandEncoderPushDebugGroup(commandEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderSetLabel(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.CommandEncoderSetLabel(commandEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1471, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderInsertDebugMarker(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderInsertDebugMarker(computePassEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1473, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderPushDebugGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderPushDebugGroup(computePassEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1474, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1475, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetLabel(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetLabel(computePassEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1480, Column 18 in webgpu.h")]
        public static unsafe void ComputePipelineSetLabel(this WebGPU thisApi, ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ComputePipelineSetLabel(computePipeline, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1483, Column 27 in webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1484, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 24 in webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1486, Column 32 in webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1487, Column 33 in webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(device, in descriptor.GetPinnableReference());
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
        [NativeName("Src", "Line 1489, Column 32 in webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 26 in webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1492, Column 32 in webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(device, in descriptor.GetPinnableReference());
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
        [NativeName("Src", "Line 1494, Column 25 in webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1495, Column 30 in webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1496, Column 27 in webgpu.h")]
        public static unsafe SwapChain* DeviceCreateSwapChain(this WebGPU thisApi, Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSwapChain(device, surface, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 25 in webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1499, Column 20 in webgpu.h")]
        public static unsafe nuint DeviceEnumerateFeatures(this WebGPU thisApi, Device* device, Span<FeatureName> features)
        {
            // SpanOverloader
            return thisApi.DeviceEnumerateFeatures(device, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1500, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DeviceGetLimits(this WebGPU thisApi, Device* device, Span<SupportedLimits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(device, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 18 in webgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePopErrorScope<T0>(this WebGPU thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DevicePopErrorScope(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1505, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetDeviceLostCallback<T0>(this WebGPU thisApi, Device* device, PfnDeviceLostCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetDeviceLostCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1506, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetLabel(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.DeviceSetLabel(device, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1507, Column 18 in webgpu.h")]
        public static unsafe void DeviceSetUncapturedErrorCallback<T0>(this WebGPU thisApi, Device* device, PfnErrorCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetUncapturedErrorCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 25 in webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(instance, in descriptor.GetPinnableReference());
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
        [NativeName("Src", "Line 1515, Column 18 in webgpu.h")]
        public static unsafe void PipelineLayoutSetLabel(this WebGPU thisApi, PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.PipelineLayoutSetLabel(pipelineLayout, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1521, Column 18 in webgpu.h")]
        public static unsafe void QuerySetSetLabel(this WebGPU thisApi, QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QuerySetSetLabel(querySet, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1524, Column 18 in webgpu.h")]
        public static unsafe void QueueOnSubmittedWorkDone<T0>(this WebGPU thisApi, Queue* queue, PfnQueueWorkDoneCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueOnSubmittedWorkDone(queue, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1525, Column 18 in webgpu.h")]
        public static unsafe void QueueSetLabel(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.QueueSetLabel(queue, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1527, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, buffer, bufferOffset, in data.GetPinnableReference(), size);
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
        [NativeName("Src", "Line 1535, Column 30 in webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(renderBundleEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1536, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderInsertDebugMarker(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderInsertDebugMarker(renderBundleEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1538, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderPushDebugGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderPushDebugGroup(renderBundleEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1539, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetLabel(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetLabel(renderBundleEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1556, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderInsertDebugMarker(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> markerLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderInsertDebugMarker(renderPassEncoder, in markerLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderPushDebugGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> groupLabel)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderPushDebugGroup(renderPassEncoder, in groupLabel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1559, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, uint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(renderPassEncoder, in color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1562, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetLabel(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetLabel(renderPassEncoder, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1571, Column 18 in webgpu.h")]
        public static unsafe void RenderPipelineSetLabel(this WebGPU thisApi, RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.RenderPipelineSetLabel(renderPipeline, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1574, Column 18 in webgpu.h")]
        public static unsafe void SamplerSetLabel(this WebGPU thisApi, Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.SamplerSetLabel(sampler, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1577, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleGetCompilationInfo<T0>(this WebGPU thisApi, ShaderModule* shaderModule, PfnCompilationInfoCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderModuleGetCompilationInfo(shaderModule, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1578, Column 18 in webgpu.h")]
        public static unsafe void ShaderModuleSetLabel(this WebGPU thisApi, ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ShaderModuleSetLabel(shaderModule, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1588, Column 29 in webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this WebGPU thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(texture, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1598, Column 18 in webgpu.h")]
        public static unsafe void TextureSetLabel(this WebGPU thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureSetLabel(texture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 18 in webgpu.h")]
        public static unsafe void TextureViewSetLabel(this WebGPU thisApi, TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.TextureViewSetLabel(textureView, in label.GetPinnableReference());
        }

    }
}

