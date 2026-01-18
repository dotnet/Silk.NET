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
        [NativeName("Src", "Line 5673, Column 26 in webgpu.h")]
        public static unsafe Instance* CreateInstance(this WebGPU thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5680, Column 18 in webgpu.h")]
        public static unsafe void GetInstanceFeatures(this WebGPU thisApi, Span<SupportedInstanceFeatures> features)
        {
            // SpanOverloader
            thisApi.GetInstanceFeatures(ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5687, Column 24 in webgpu.h")]
        public static unsafe Status GetInstanceLimits(this WebGPU thisApi, Span<InstanceLimits> limits)
        {
            // SpanOverloader
            return thisApi.GetInstanceLimits(ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5719, Column 18 in webgpu.h")]
        public static unsafe void AdapterGetFeatures(this WebGPU thisApi, Adapter* adapter, Span<SupportedFeatures> features)
        {
            // SpanOverloader
            thisApi.AdapterGetFeatures(adapter, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5727, Column 24 in webgpu.h")]
        public static unsafe Status AdapterGetInfo(this WebGPU thisApi, Adapter* adapter, Span<AdapterInfo> info)
        {
            // SpanOverloader
            return thisApi.AdapterGetInfo(adapter, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5732, Column 24 in webgpu.h")]
        public static unsafe Status AdapterGetLimits(this WebGPU thisApi, Adapter* adapter, Span<Limits> limits)
        {
            // SpanOverloader
            return thisApi.AdapterGetLimits(adapter, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5734, Column 24 in webgpu.h")]
        public static unsafe Future AdapterRequestDevice(this WebGPU thisApi, Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor, RequestDeviceCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.AdapterRequestDevice(adapter, in descriptor.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5851, Column 24 in webgpu.h")]
        public static unsafe Status BufferReadMappedRange<T0>(this WebGPU thisApi, Buffer* buffer, nuint offset, Span<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BufferReadMappedRange(buffer, offset, ref data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5874, Column 24 in webgpu.h")]
        public static unsafe Status BufferWriteMappedRange<T0>(this WebGPU thisApi, Buffer* buffer, nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BufferWriteMappedRange(buffer, offset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5902, Column 36 in webgpu.h")]
        public static unsafe ComputePassEncoder* CommandEncoderBeginComputePass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginComputePass(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5907, Column 35 in webgpu.h")]
        public static unsafe RenderPassEncoder* CommandEncoderBeginRenderPass(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPassDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderBeginRenderPass(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5910, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyBufferToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyBufferToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5911, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToBuffer(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToBuffer(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5912, Column 18 in webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTexture(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTexture(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5917, Column 31 in webgpu.h")]
        public static unsafe CommandBuffer* CommandEncoderFinish(this WebGPU thisApi, CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandBufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.CommandEncoderFinish(commandEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5941, Column 18 in webgpu.h")]
        public static unsafe void ComputePassEncoderSetBindGroup(this WebGPU thisApi, ComputePassEncoder* computePassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetBindGroup(computePassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5976, Column 27 in webgpu.h")]
        public static unsafe BindGroup* DeviceCreateBindGroup(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroup(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5981, Column 33 in webgpu.h")]
        public static unsafe BindGroupLayout* DeviceCreateBindGroupLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BindGroupLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBindGroupLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5991, Column 38 in webgpu.h")]
        public static unsafe Buffer* DeviceCreateBuffer(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateBuffer(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5996, Column 32 in webgpu.h")]
        public static unsafe CommandEncoder* DeviceCreateCommandEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CommandEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateCommandEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6001, Column 33 in webgpu.h")]
        public static unsafe ComputePipeline* DeviceCreateComputePipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipeline(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6002, Column 24 in webgpu.h")]
        public static unsafe Future DeviceCreateComputePipelineAsync(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ComputePipelineDescriptor> descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.DeviceCreateComputePipelineAsync(device, in descriptor.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6007, Column 32 in webgpu.h")]
        public static unsafe PipelineLayout* DeviceCreatePipelineLayout(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineLayoutDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreatePipelineLayout(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6012, Column 26 in webgpu.h")]
        public static unsafe QuerySet* DeviceCreateQuerySet(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<QuerySetDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateQuerySet(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6017, Column 37 in webgpu.h")]
        public static unsafe RenderBundleEncoder* DeviceCreateRenderBundleEncoder(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleEncoderDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderBundleEncoder(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6022, Column 32 in webgpu.h")]
        public static unsafe RenderPipeline* DeviceCreateRenderPipeline(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipeline(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6023, Column 24 in webgpu.h")]
        public static unsafe Future DeviceCreateRenderPipelineAsync(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderPipelineDescriptor> descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.DeviceCreateRenderPipelineAsync(device, in descriptor.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6028, Column 25 in webgpu.h")]
        public static unsafe Sampler* DeviceCreateSampler(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SamplerDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateSampler(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6033, Column 30 in webgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModule(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModule(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6038, Column 25 in webgpu.h")]
        public static unsafe Texture* DeviceCreateTexture(this WebGPU thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6047, Column 24 in webgpu.h")]
        public static unsafe Status DeviceGetAdapterInfo(this WebGPU thisApi, Device* device, Span<AdapterInfo> adapterInfo)
        {
            // SpanOverloader
            return thisApi.DeviceGetAdapterInfo(device, ref adapterInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6054, Column 18 in webgpu.h")]
        public static unsafe void DeviceGetFeatures(this WebGPU thisApi, Device* device, Span<SupportedFeatures> features)
        {
            // SpanOverloader
            thisApi.DeviceGetFeatures(device, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6059, Column 24 in webgpu.h")]
        public static unsafe Status DeviceGetLimits(this WebGPU thisApi, Device* device, Span<Limits> limits)
        {
            // SpanOverloader
            return thisApi.DeviceGetLimits(device, ref limits.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6103, Column 25 in webgpu.h")]
        public static unsafe Surface* InstanceCreateSurface(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.InstanceCreateSurface(instance, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6107, Column 18 in webgpu.h")]
        public static unsafe void InstanceGetWGSLLanguageFeatures(this WebGPU thisApi, Instance* instance, Span<SupportedWGSLLanguageFeatures> features)
        {
            // SpanOverloader
            thisApi.InstanceGetWGSLLanguageFeatures(instance, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6115, Column 24 in webgpu.h")]
        public static unsafe Future InstanceRequestAdapter(this WebGPU thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RequestAdapterOptions> options, RequestAdapterCallbackInfo callbackInfo)
        {
            // SpanOverloader
            return thisApi.InstanceRequestAdapter(instance, in options.GetPinnableReference(), callbackInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6121, Column 28 in webgpu.h")]
        public static unsafe WaitStatus InstanceWaitAny(this WebGPU thisApi, Instance* instance, nuint futureCount, Span<FutureWaitInfo> futures, ulong timeoutNS)
        {
            // SpanOverloader
            return thisApi.InstanceWaitAny(instance, futureCount, ref futures.GetPinnableReference(), timeoutNS);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6167, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteBuffer<T0>(this WebGPU thisApi, Queue* queue, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteBuffer(queue, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyTextureInfo* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, destination, in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize)
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), data, dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexelCopyBufferLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, dataLayout, in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), writeSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6168, Column 18 in webgpu.h")]
        public static unsafe void QueueWriteTexture<T0>(this WebGPU thisApi, Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyTextureInfo> destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TexelCopyBufferLayout> dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Extent3D> writeSize) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.QueueWriteTexture(queue, in destination.GetPinnableReference(), in data.GetPinnableReference(), dataSize, in dataLayout.GetPinnableReference(), in writeSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6200, Column 30 in webgpu.h")]
        public static unsafe RenderBundle* RenderBundleEncoderFinish(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderBundleDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.RenderBundleEncoderFinish(renderBundleEncoder, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6204, Column 18 in webgpu.h")]
        public static unsafe void RenderBundleEncoderSetBindGroup(this WebGPU thisApi, RenderBundleEncoder* renderBundleEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetBindGroup(renderBundleEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6231, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBindGroup(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, uint groupIndex, BindGroup* group, nuint dynamicOffsetCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> dynamicOffsets)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBindGroup(renderPassEncoder, groupIndex, group, dynamicOffsetCount, in dynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6236, Column 18 in webgpu.h")]
        public static unsafe void RenderPassEncoderSetBlendConstant(this WebGPU thisApi, RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetBlendConstant(renderPassEncoder, in color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6350, Column 18 in webgpu.h")]
        public static unsafe void SurfaceConfigure(this WebGPU thisApi, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SurfaceConfiguration> config)
        {
            // SpanOverloader
            thisApi.SurfaceConfigure(surface, in config.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6366, Column 24 in webgpu.h")]
        public static unsafe Status SurfaceGetCapabilities(this WebGPU thisApi, Surface* surface, Adapter* adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            return thisApi.SurfaceGetCapabilities(surface, adapter, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6376, Column 18 in webgpu.h")]
        public static unsafe void SurfaceGetCurrentTexture(this WebGPU thisApi, Surface* surface, Span<SurfaceTexture> surfaceTexture)
        {
            // SpanOverloader
            thisApi.SurfaceGetCurrentTexture(surface, ref surfaceTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6425, Column 29 in webgpu.h")]
        public static unsafe TextureView* TextureCreateView(this WebGPU thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TextureViewDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.TextureCreateView(texture, in descriptor.GetPinnableReference());
        }

    }
}

