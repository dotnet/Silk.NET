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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVGpuMulticastOverloads
    {
        public static unsafe void MulticastBufferSubData<T0>(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MulticastBufferSubData(gpuMask, buffer, offset, size, in data.GetPinnableReference());
        }

        public static unsafe void MulticastFramebufferSampleLocations(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MulticastFramebufferSampleLocations(gpu, framebuffer, start, count, in v.GetPinnableReference());
        }

        public static unsafe void MulticastGetQueryObject(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.MulticastGetQueryObject(gpu, id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void MulticastGetQueryObject(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.MulticastGetQueryObject(gpu, id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void MulticastGetQueryObject(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.MulticastGetQueryObject(gpu, id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void MulticastGetQueryObject(this NVGpuMulticast thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.MulticastGetQueryObject(gpu, id, pname, out @params.GetPinnableReference());
        }

    }
}

