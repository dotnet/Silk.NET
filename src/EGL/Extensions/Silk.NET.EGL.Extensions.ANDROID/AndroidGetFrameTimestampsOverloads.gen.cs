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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public static class AndroidGetFrameTimestampsOverloads
    {
        public static unsafe int GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* names, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, names, out values.GetPinnableReference());
        }

        public static unsafe int GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] ReadOnlySpan<int> names, [Flow(FlowDirection.Out)] long* values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, in names.GetPinnableReference(), values);
        }

        public static unsafe int GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] ReadOnlySpan<int> names, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, in names.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe int GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] int* timestamps, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, timestamps, out values.GetPinnableReference());
        }

        public static unsafe int GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] ReadOnlySpan<int> timestamps, [Flow(FlowDirection.Out)] long* values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, in timestamps.GetPinnableReference(), values);
        }

        public static unsafe int GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ulong frameId, [Flow(FlowDirection.In)] int numTimestamps, [Flow(FlowDirection.In)] ReadOnlySpan<int> timestamps, [Flow(FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, in timestamps.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe int GetNextFrameId(this AndroidGetFrameTimestamps thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] Span<ulong> frameId)
        {
            // SpanOverloader
            return thisApi.GetNextFrameId(dpy, surface, out frameId.GetPinnableReference());
        }

    }
}

