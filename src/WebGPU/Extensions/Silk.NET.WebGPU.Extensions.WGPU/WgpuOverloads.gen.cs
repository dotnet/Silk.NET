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
        [NativeName("Src", "Line 291, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Instance* instance, Span<GlobalReport> report)
        {
            // SpanOverloader
            thisApi.GenerateReport(instance, ref report.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        public static unsafe nuint InstanceEnumerateAdapters(this Wgpu thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceEnumerateAdapterOptions> options, Adapter** adapters)
        {
            // SpanOverloader
            return thisApi.InstanceEnumerateAdapters(instance, in options.GetPinnableReference(), adapters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 8 in wgpu.h")]
        public static unsafe nuint InstanceEnumerateAdapters(this Wgpu thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceEnumerateAdapterOptions> options, ref Adapter* adapters)
        {
            // SpanOverloader
            return thisApi.InstanceEnumerateAdapters(instance, in options.GetPinnableReference(), ref adapters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 10 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> submissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(device, wait, in submissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 18 in wgpu.h")]
        public static unsafe ShaderModule* DeviceCreateShaderModuleSpirV(this Wgpu thisApi, Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShaderModuleDescriptorSpirV> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateShaderModuleSpirV(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 6 in wgpu.h")]
        public static unsafe void SetLogCallback<T0>(this Wgpu thisApi, PfnLogCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLogCallback(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderPassEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 6 in wgpu.h")]
        public static unsafe void ComputePassEncoderSetPushConstants<T0>(this Wgpu thisApi, ComputePassEncoder* encoder, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ComputePassEncoderSetPushConstants(encoder, offset, sizeBytes, in data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 6 in wgpu.h")]
        public static unsafe void RenderBundleEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderBundleEncoder* encoder, ulong stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

    }
}

