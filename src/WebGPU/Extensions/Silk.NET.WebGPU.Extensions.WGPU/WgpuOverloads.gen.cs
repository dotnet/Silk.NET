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
        [NativeName("Src", "Line 61, Column 6 in wgpu.h")]
        public static unsafe void RenderPassEncoderSetPushConstants<T0>(this Wgpu thisApi, RenderPassEncoder* encoder, ShaderStage stages, uint offset, uint sizeBytes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.RenderPassEncoderSetPushConstants(encoder, stages, offset, sizeBytes, in data.GetPinnableReference());
        }

    }
}

