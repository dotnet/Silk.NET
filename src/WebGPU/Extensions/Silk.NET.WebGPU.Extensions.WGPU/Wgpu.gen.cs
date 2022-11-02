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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Extension("wgpu.h")]
    public unsafe partial class Wgpu : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "wgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(GlobalReport* report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public partial void GenerateReport(ref GlobalReport report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(ref Queue queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(ref Queue queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial bool DevicePoll(Device* device, bool wait, WrappedSubmissionIndex* wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial bool DevicePoll(Device* device, bool wait, ref WrappedSubmissionIndex wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial bool DevicePoll(ref Device device, bool wait, WrappedSubmissionIndex* wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public partial bool DevicePoll(ref Device device, bool wait, ref WrappedSubmissionIndex wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public unsafe partial void SetLogCallback(PfnLogCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback<T0>(PfnLogCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(Surface* surface, Adapter* adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(Surface* surface, Adapter* adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(Surface* surface, ref Adapter adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(Surface* surface, ref Adapter adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(ref Surface surface, Adapter* adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(ref Surface surface, Adapter* adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(ref Surface surface, ref Adapter adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 27 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedFormats")]
        public unsafe partial TextureFormat* SurfaceGetSupportedFormats(ref Surface surface, ref Adapter adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(Surface* surface, Adapter* adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(Surface* surface, Adapter* adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(Surface* surface, ref Adapter adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(Surface* surface, ref Adapter adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(ref Surface surface, Adapter* adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(ref Surface surface, Adapter* adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(ref Surface surface, ref Adapter adapter, nuint* count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 25 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetSupportedPresentModes")]
        public unsafe partial PresentMode* SurfaceGetSupportedPresentModes(ref Surface surface, ref Adapter adapter, ref nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(RenderPassEncoder* encoder, uint stages, uint offset, uint sizeBytes, void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants<T0>(RenderPassEncoder* encoder, uint stages, uint offset, uint sizeBytes, ref T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(ref RenderPassEncoder encoder, uint stages, uint offset, uint sizeBytes, void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public partial void RenderPassEncoderSetPushConstants<T0>(ref RenderPassEncoder encoder, uint stages, uint offset, uint sizeBytes, ref T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public partial void RenderPassEncoderMultiDrawIndirect(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public partial void RenderPassEncoderMultiDrawIndexedIndirect(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public partial void RenderPassEncoderMultiDrawIndirectCount(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, ref Buffer buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(ref RenderPassEncoder encoder, Buffer* buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public partial void RenderPassEncoderMultiDrawIndexedIndirectCount(ref RenderPassEncoder encoder, ref Buffer buffer, ulong offset, ref Buffer count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 171, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterDrop")]
        public unsafe partial void AdapterDrop(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 171, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterDrop")]
        public partial void AdapterDrop(ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupDrop")]
        public unsafe partial void BindGroupDrop(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupDrop")]
        public partial void BindGroupDrop(ref BindGroup bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutDrop")]
        public unsafe partial void BindGroupLayoutDrop(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutDrop")]
        public partial void BindGroupLayoutDrop(ref BindGroupLayout bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDrop")]
        public unsafe partial void BufferDrop(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDrop")]
        public partial void BufferDrop(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferDrop")]
        public unsafe partial void CommandBufferDrop(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferDrop")]
        public partial void CommandBufferDrop(ref CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 176, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderDrop")]
        public unsafe partial void CommandEncoderDrop(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 176, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderDrop")]
        public partial void CommandEncoderDrop(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineDrop")]
        public unsafe partial void ComputePipelineDrop(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineDrop")]
        public partial void ComputePipelineDrop(ref ComputePipeline computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDrop")]
        public unsafe partial void DeviceDrop(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDrop")]
        public partial void DeviceDrop(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutDrop")]
        public unsafe partial void PipelineLayoutDrop(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutDrop")]
        public partial void PipelineLayoutDrop(ref PipelineLayout pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDrop")]
        public unsafe partial void QuerySetDrop(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDrop")]
        public partial void QuerySetDrop(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 181, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleDrop")]
        public unsafe partial void RenderBundleDrop(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 181, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleDrop")]
        public partial void RenderBundleDrop(ref RenderBundle renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineDrop")]
        public unsafe partial void RenderPipelineDrop(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineDrop")]
        public partial void RenderPipelineDrop(ref RenderPipeline renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerDrop")]
        public unsafe partial void SamplerDrop(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerDrop")]
        public partial void SamplerDrop(ref Sampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleDrop")]
        public unsafe partial void ShaderModuleDrop(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleDrop")]
        public partial void ShaderModuleDrop(ref ShaderModule shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceDrop")]
        public unsafe partial void SurfaceDrop(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceDrop")]
        public partial void SurfaceDrop(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDrop")]
        public unsafe partial void TextureDrop(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDrop")]
        public partial void TextureDrop(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 187, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewDrop")]
        public unsafe partial void TextureViewDrop(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 187, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewDrop")]
        public partial void TextureViewDrop(ref TextureView textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuFree")]
        public unsafe partial void Free(void* ptr, nuint size, nuint align);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuFree")]
        public partial void Free<T0>(ref T0 ptr, nuint size, nuint align) where T0 : unmanaged;

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

