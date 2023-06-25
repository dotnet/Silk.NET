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
        [NativeName("Src", "Line 192, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, GlobalReport* report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, ref GlobalReport report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in InstanceEnumerateAdapterOptions options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in InstanceEnumerateAdapterOptions options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 195, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, uint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 195, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, uint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WrappedSubmissionIndex* wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in WrappedSubmissionIndex wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public unsafe partial void SetLogCallback(PfnLogCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback<T0>(PfnLogCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCapabilities")]
        public unsafe partial void SurfaceGetCapabilities(Surface* surface, Adapter* adapter, SurfaceCapabilities* capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetCapabilities")]
        public unsafe partial void SurfaceGetCapabilities(Surface* surface, Adapter* adapter, ref SurfaceCapabilities capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants<T0>(RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 213, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterDrop")]
        public unsafe partial void AdapterDrop(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 217, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupDrop")]
        public unsafe partial void BindGroupDrop(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutDrop")]
        public unsafe partial void BindGroupLayoutDrop(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferDrop")]
        public unsafe partial void BufferDrop(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferDrop")]
        public unsafe partial void CommandBufferDrop(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderDrop")]
        public unsafe partial void CommandEncoderDrop(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDrop")]
        public unsafe partial void ComputePassEncoderDrop(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineDrop")]
        public unsafe partial void ComputePipelineDrop(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceDrop")]
        public unsafe partial void DeviceDrop(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceDrop")]
        public unsafe partial void InstanceDrop(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 226, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutDrop")]
        public unsafe partial void PipelineLayoutDrop(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetDrop")]
        public unsafe partial void QuerySetDrop(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueDrop")]
        public unsafe partial void QueueDrop(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleDrop")]
        public unsafe partial void RenderBundleDrop(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderDrop")]
        public unsafe partial void RenderBundleEncoderDrop(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderDrop")]
        public unsafe partial void RenderPassEncoderDrop(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineDrop")]
        public unsafe partial void RenderPipelineDrop(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 233, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerDrop")]
        public unsafe partial void SamplerDrop(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleDrop")]
        public unsafe partial void ShaderModuleDrop(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceDrop")]
        public unsafe partial void SurfaceDrop(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainDrop")]
        public unsafe partial void SwapChainDrop(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureDrop")]
        public unsafe partial void TextureDrop(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewDrop")]
        public unsafe partial void TextureViewDrop(TextureView* textureView);

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

