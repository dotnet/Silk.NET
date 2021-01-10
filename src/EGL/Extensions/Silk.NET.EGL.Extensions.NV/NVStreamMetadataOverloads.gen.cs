// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.EGL.Extensions.NV
{
    public static class NVStreamMetadataOverloads
    {
        public static unsafe bool QueryDisplayAttrib(this NVStreamMetadata thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDisplayAttrib(dpy, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryStreamMetadata<T0>(this NVStreamMetadata thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryStreamMetadata(dpy, stream, name, n, offset, size, out data.GetPinnableReference());
        }

        public static unsafe bool SetStreamMetadata<T0>(this NVStreamMetadata thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetStreamMetadata(dpy, stream, n, offset, size, in data.GetPinnableReference());
        }

    }
}

