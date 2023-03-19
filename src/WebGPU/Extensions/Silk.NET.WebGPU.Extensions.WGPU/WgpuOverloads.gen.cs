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
        [NativeName("Src", "Line 191, Column 6 in wgpu.h")]
        public static unsafe Silk.NET.Core.Bool32 DevicePoll(this Wgpu thisApi, Device* device, Silk.NET.Core.Bool32 wait, [Flow(FlowDirection.In)] ReadOnlySpan<WrappedSubmissionIndex> wrappedSubmissionIndex)
        {
            // SpanOverloader
            return thisApi.DevicePoll(device, wait, in wrappedSubmissionIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 6 in wgpu.h")]
        public static unsafe void SetLogCallback<T0>(this Wgpu thisApi, PfnLogCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLogCallback(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 6 in wgpu.h")]
        public static unsafe void SurfaceGetCapabilities(this Wgpu thisApi, Surface* surface, Adapter* adapter, Span<SurfaceCapabilities> capabilities)
        {
            // SpanOverloader
            thisApi.SurfaceGetCapabilities(surface, adapter, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderPassEncoder* encoder, Silk.NET.WebGPU.ShaderStage stages, uint offset, uint sizeBytes, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

    }
}

