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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    public static class WgpuOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Span<GlobalReport> report)
        {
            // SpanOverloader
            thisApi.GenerateReport(ref report.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        public static unsafe ulong QueueSubmitForIndex(this Wgpu thisApi, Span<Queue> queue, uint commandCount, [Flow(FlowDirection.In)] CommandBuffer** commands)
        {
            // SpanOverloader
            return thisApi.QueueSubmitForIndex(ref queue.GetPinnableReference(), commandCount, commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        public static unsafe ulong QueueSubmitForIndex(this Wgpu thisApi, Span<Queue> queue, uint commandCount, [Flow(FlowDirection.In)] in CommandBuffer* commands)
        {
            // SpanOverloader
            return thisApi.QueueSubmitForIndex(ref queue.GetPinnableReference(), commandCount, in commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        public static unsafe bool DevicePoll(this Wgpu thisApi, Device* device, bool wait, [Flow(FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(device, wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        public static unsafe bool DevicePoll(this Wgpu thisApi, Span<Device> device, bool wait, [Flow(FlowDirection.In)] WrappedSubmissionIndex* wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(ref device.GetPinnableReference(), wait, wrappedSubmissionIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        public static unsafe bool DevicePoll(this Wgpu thisApi, Span<Device> device, bool wait, [Flow(FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(ref device.GetPinnableReference(), wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 6 in wgpu.h")]
        public static unsafe void SetLogCallback<T0>(this Wgpu thisApi, PfnLogCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLogCallback(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Surface* surface, Adapter* adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(surface, adapter, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(surface, ref adapter.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(surface, ref adapter.GetPinnableReference(), ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(ref surface.GetPinnableReference(), adapter, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(ref surface.GetPinnableReference(), adapter, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        public static unsafe TextureFormat* SurfaceGetSupportedFormats(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedFormats(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Surface* surface, Adapter* adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(surface, adapter, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(surface, ref adapter.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(surface, ref adapter.GetPinnableReference(), ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(ref surface.GetPinnableReference(), adapter, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(ref surface.GetPinnableReference(), adapter, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, nuint* count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        public static unsafe PresentMode* SurfaceGetSupportedPresentModes(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, Span<nuint> count)
        {
            // SpanOverloader
            return thisApi.SurfaceGetSupportedPresentModes(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderPassEncoder* encoder, uint stages, uint offset, uint sizeBytes, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants(this Wgpu thisApi, Span<RenderPassEncoder> encoder, uint stages, uint offset, uint sizeBytes, [Flow(FlowDirection.In)] void* data)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(ref encoder.GetPinnableReference(), stages, offset, sizeBytes, data);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, Span<RenderPassEncoder> encoder, uint stages, uint offset, uint sizeBytes, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(ref encoder.GetPinnableReference(), stages, offset, sizeBytes, in data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(encoder, ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(ref encoder.GetPinnableReference(), buffer, offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(encoder, ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(ref encoder.GetPinnableReference(), buffer, offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 171, Column 6 in wgpu.h")]
        public static unsafe void AdapterDrop(this Wgpu thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterDrop(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 6 in wgpu.h")]
        public static unsafe void BindGroupDrop(this Wgpu thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupDrop(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 6 in wgpu.h")]
        public static unsafe void BindGroupLayoutDrop(this Wgpu thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutDrop(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 6 in wgpu.h")]
        public static unsafe void BufferDrop(this Wgpu thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferDrop(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 6 in wgpu.h")]
        public static unsafe void CommandBufferDrop(this Wgpu thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferDrop(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 176, Column 6 in wgpu.h")]
        public static unsafe void CommandEncoderDrop(this Wgpu thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderDrop(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 6 in wgpu.h")]
        public static unsafe void ComputePipelineDrop(this Wgpu thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineDrop(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 6 in wgpu.h")]
        public static unsafe void DeviceDrop(this Wgpu thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceDrop(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 6 in wgpu.h")]
        public static unsafe void PipelineLayoutDrop(this Wgpu thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutDrop(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 6 in wgpu.h")]
        public static unsafe void QuerySetDrop(this Wgpu thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetDrop(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 181, Column 6 in wgpu.h")]
        public static unsafe void RenderBundleDrop(this Wgpu thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleDrop(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 6 in wgpu.h")]
        public static unsafe void RenderPipelineDrop(this Wgpu thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineDrop(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 6 in wgpu.h")]
        public static unsafe void SamplerDrop(this Wgpu thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerDrop(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 6 in wgpu.h")]
        public static unsafe void ShaderModuleDrop(this Wgpu thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleDrop(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 6 in wgpu.h")]
        public static unsafe void SurfaceDrop(this Wgpu thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceDrop(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        public static unsafe void TextureDrop(this Wgpu thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureDrop(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 187, Column 6 in wgpu.h")]
        public static unsafe void TextureViewDrop(this Wgpu thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewDrop(ref textureView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        public static unsafe void Free<T0>(this Wgpu thisApi, Span<T0> ptr, nuint size, nuint align) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Free(ref ptr.GetPinnableReference(), size, align);
        }

    }
}

