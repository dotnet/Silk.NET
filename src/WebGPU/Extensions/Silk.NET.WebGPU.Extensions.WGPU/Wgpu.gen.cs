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
        [NativeName("Src", "Line 291, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, GlobalReport* report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 291, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGenerateReport")]
        public unsafe partial void GenerateReport(Instance* instance, ref GlobalReport report);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceEnumerateAdapterOptions* options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InstanceEnumerateAdapterOptions options, Adapter** adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateAdapters")]
        public unsafe partial nuint InstanceEnumerateAdapters(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InstanceEnumerateAdapterOptions options, ref Adapter* adapters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, CommandBuffer** commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 21 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSubmitForIndex")]
        public unsafe partial ulong QueueSubmitForIndex(Queue* queue, nuint commandCount, ref CommandBuffer* commands);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* submissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePoll")]
        public unsafe partial Silk.NET.Core.Bool32 DevicePoll(Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ulong submissionIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 18 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleSpirV")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleSpirV(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptorSpirV* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 18 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateShaderModuleSpirV")]
        public unsafe partial ShaderModule* DeviceCreateShaderModuleSpirV(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptorSpirV descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public unsafe partial void SetLogCallback(PfnLogCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogCallback")]
        public partial void SetLogCallback<T0>(PfnLogCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuSetLogLevel")]
        public partial void SetLogLevel(LogLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 10 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetVersion")]
        public partial uint GetVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants(RenderPassEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
        public unsafe partial void RenderPassEncoderSetPushConstants<T0>(RenderPassEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPushConstants")]
        public unsafe partial void ComputePassEncoderSetPushConstants(ComputePassEncoder* encoder, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetPushConstants")]
        public unsafe partial void ComputePassEncoderSetPushConstants<T0>(ComputePassEncoder* encoder, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPushConstants")]
        public unsafe partial void RenderBundleEncoderSetPushConstants(RenderBundleEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetPushConstants")]
        public unsafe partial void RenderBundleEncoderSetPushConstants<T0>(RenderBundleEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirect(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, uint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
        public unsafe partial void RenderPassEncoderMultiDrawIndexedIndirectCount(RenderPassEncoder* encoder, Buffer* buffer, ulong offset, Buffer* count_buffer, ulong count_buffer_offset, uint max_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderBeginPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void ComputePassEncoderEndPipelineStatisticsQuery(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderBeginPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
        public unsafe partial void RenderPassEncoderEndPipelineStatisticsQuery(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 6 in wgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        public Wgpu(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

