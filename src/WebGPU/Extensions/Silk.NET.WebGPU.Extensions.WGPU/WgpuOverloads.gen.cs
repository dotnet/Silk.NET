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
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Instance* instance, Span<GlobalReport> report)
        {
            // SpanOverloader
            thisApi.GenerateReport(instance, ref report.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Span<Instance> instance, GlobalReport* report)
        {
            // SpanOverloader
            thisApi.GenerateReport(ref instance.GetPinnableReference(), report);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Span<Instance> instance, Span<GlobalReport> report)
        {
            // SpanOverloader
            thisApi.GenerateReport(ref instance.GetPinnableReference(), ref report.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 21 in wgpu.h")]
        public static unsafe ulong QueueSubmitForIndex(this Wgpu thisApi, Span<Queue> queue, uint commandCount, CommandBuffer** commands)
        {
            // SpanOverloader
            return thisApi.QueueSubmitForIndex(ref queue.GetPinnableReference(), commandCount, commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 21 in wgpu.h")]
        public static unsafe ulong QueueSubmitForIndex(this Wgpu thisApi, Span<Queue> queue, uint commandCount, ref CommandBuffer* commands)
        {
            // SpanOverloader
            return thisApi.QueueSubmitForIndex(ref queue.GetPinnableReference(), commandCount, ref commands);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Device* device, Silk.NET.Core.Bool32 wait, [Flow(FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(device, wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Span<Device> device, Silk.NET.Core.Bool32 wait, [Flow(FlowDirection.In)] WrappedSubmissionIndex* wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(ref device.GetPinnableReference(), wait, wrappedSubmissionIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Span<Device> device, Silk.NET.Core.Bool32 wait, [Flow(FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(ref device.GetPinnableReference(), wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Surface* surface, Adapter* adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(surface, adapter, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, SurfaceCapabilities* capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(surface, ref adapter.GetPinnableReference(), capabilities);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Surface* surface, Span<Adapter> adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(surface, ref adapter.GetPinnableReference(), ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, SurfaceCapabilities* capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(ref surface.GetPinnableReference(), adapter, capabilities);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Span<Surface> surface, Adapter* adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(ref surface.GetPinnableReference(), adapter, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, SurfaceCapabilities* capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), capabilities);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Span<Surface> surface, Span<Adapter> adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(ref surface.GetPinnableReference(), ref adapter.GetPinnableReference(), ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.RenderPassEncoderSetPushConstants(ref encoder.GetPinnableReference(), stages, offset, sizeBytes, dataSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(encoder, ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(ref encoder.GetPinnableReference(), buffer, offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirect(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(encoder, ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(ref encoder.GetPinnableReference(), buffer, offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirect(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, uint count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirect(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, RenderPassEncoder* encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(encoder, ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Buffer* buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), buffer, offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, count_buffer, count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 207, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderMultiDrawIndexedIndirectCount(this Wgpu thisApi, Span<RenderPassEncoder> encoder, Span<Buffer> buffer, ulong offset, Span<Buffer> count_buffer, ulong count_buffer_offset, uint max_count)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderMultiDrawIndexedIndirectCount(ref encoder.GetPinnableReference(), ref buffer.GetPinnableReference(), offset, ref count_buffer.GetPinnableReference(), count_buffer_offset, max_count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 209, Column 6 in wgpu.h")]
        public static unsafe void InstanceDrop(this Wgpu thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceDrop(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 6 in wgpu.h")]
        public static unsafe void AdapterDrop(this Wgpu thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterDrop(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 6 in wgpu.h")]
        public static unsafe void BindGroupDrop(this Wgpu thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupDrop(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 212, Column 6 in wgpu.h")]
        public static unsafe void BindGroupLayoutDrop(this Wgpu thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutDrop(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 213, Column 6 in wgpu.h")]
        public static unsafe void BufferDrop(this Wgpu thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferDrop(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 6 in wgpu.h")]
        public static unsafe void CommandBufferDrop(this Wgpu thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferDrop(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 6 in wgpu.h")]
        public static unsafe void CommandEncoderDrop(this Wgpu thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderDrop(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderDrop(this Wgpu thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderDrop(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 217, Column 6 in wgpu.h")]
        public static unsafe void ComputePassEncoderDrop(this Wgpu thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDrop(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 6 in wgpu.h")]
        public static unsafe void RenderBundleEncoderDrop(this Wgpu thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderDrop(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 6 in wgpu.h")]
        public static unsafe void ComputePipelineDrop(this Wgpu thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineDrop(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 6 in wgpu.h")]
        public static unsafe void DeviceDrop(this Wgpu thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceDrop(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 6 in wgpu.h")]
        public static unsafe void PipelineLayoutDrop(this Wgpu thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutDrop(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 6 in wgpu.h")]
        public static unsafe void QuerySetDrop(this Wgpu thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetDrop(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 6 in wgpu.h")]
        public static unsafe void RenderBundleDrop(this Wgpu thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleDrop(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 6 in wgpu.h")]
        public static unsafe void RenderPipelineDrop(this Wgpu thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineDrop(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 6 in wgpu.h")]
        public static unsafe void SamplerDrop(this Wgpu thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerDrop(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 226, Column 6 in wgpu.h")]
        public static unsafe void ShaderModuleDrop(this Wgpu thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleDrop(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 6 in wgpu.h")]
        public static unsafe void SurfaceDrop(this Wgpu thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceDrop(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in wgpu.h")]
        public static unsafe void SwapChainDrop(this Wgpu thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainDrop(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 6 in wgpu.h")]
        public static unsafe void TextureDrop(this Wgpu thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureDrop(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 6 in wgpu.h")]
        public static unsafe void TextureViewDrop(this Wgpu thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewDrop(ref textureView.GetPinnableReference());
        }

    }
}

