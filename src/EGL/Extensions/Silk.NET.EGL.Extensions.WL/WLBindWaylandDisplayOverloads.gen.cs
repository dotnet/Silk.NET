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

namespace Silk.NET.EGL.Extensions.WL
{
    public static class WLBindWaylandDisplayOverloads
    {
        public static unsafe bool BindWaylandDisplayWL(this WLBindWaylandDisplay thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> display)
        {
            // SpanOverloader
            return thisApi.BindWaylandDisplayWL(dpy, out display.GetPinnableReference());
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, buffer, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, out buffer.GetPinnableReference(), attribute, value);
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, out buffer.GetPinnableReference(), attribute, out value.GetPinnableReference());
        }

        public static unsafe bool UnbindWaylandDisplayWL(this WLBindWaylandDisplay thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> display)
        {
            // SpanOverloader
            return thisApi.UnbindWaylandDisplayWL(dpy, out display.GetPinnableReference());
        }

    }
}

