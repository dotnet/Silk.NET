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
        [NativeName("Src", "Line 259, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, GlobalReport* report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 259, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, ref GlobalReport report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceEnumerateAdapterOptions options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceEnumerateAdapterOptions options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 265, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WrappedSubmissionIndex* wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 265, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WrappedSubmissionIndex wrappedSubmissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public unsafe partial void SetLogCallback(PfnLogCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback<T0>(PfnLogCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 271, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants<T0>(RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 278, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder);

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

