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
        [NativeName("Src", "Line 259, Column 6 in wgpu.h")]
        public static unsafe void GenerateReport(this Wgpu thisApi, Instance* instance, Span<GlobalReport> report)
        {
            // SpanOverloader
            thisApi.GenerateReport(instance, ref report.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        public static unsafe nuint InstanceEnumerateAdapters(this Wgpu thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceEnumerateAdapterOptions> options, Adapter** adapters)
        {
            // SpanOverloader
            return thisApi.InstanceEnumerateAdapters(instance, in options.GetPinnableReference(), adapters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 8 in wgpu.h")]
        public static unsafe nuint InstanceEnumerateAdapters(this Wgpu thisApi, Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceEnumerateAdapterOptions> options, ref Adapter* adapters)
        {
            // SpanOverloader
            return thisApi.InstanceEnumerateAdapters(instance, in options.GetPinnableReference(), ref adapters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 265, Column 10 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Device* device, Silk.NET.Core.Bool32 wait, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(device, wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 6 in wgpu.h")]
        public static unsafe void SetLogCallback<T0>(this Wgpu thisApi, PfnLogCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLogCallback(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

    }
}

