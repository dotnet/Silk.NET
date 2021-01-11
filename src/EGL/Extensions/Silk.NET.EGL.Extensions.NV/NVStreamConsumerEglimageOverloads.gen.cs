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
    public static class NVStreamConsumerEglimageOverloads
    {
        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] NV* @event, [Flow(FlowDirection.Out)] Span<nint> aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, @event, out aux.GetPinnableReference());
        }

        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] Span<NV> @event, [Flow(FlowDirection.Out)] nint* aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, out @event.GetPinnableReference(), aux);
        }

        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] Span<NV> @event, [Flow(FlowDirection.Out)] Span<nint> aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, out @event.GetPinnableReference(), out aux.GetPinnableReference());
        }

        public static unsafe int StreamAcquireImage(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.Out)] Span<nint> pImage, [Flow(FlowDirection.In)] nint sync)
        {
            // SpanOverloader
            return thisApi.StreamAcquireImage(dpy, stream, out pImage.GetPinnableReference(), sync);
        }

        public static unsafe int StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] Span<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, modifiers, out attrib_list.GetPinnableReference());
        }

        public static unsafe int StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] nint* attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, out modifiers.GetPinnableReference(), attrib_list);
        }

        public static unsafe int StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, out modifiers.GetPinnableReference(), out attrib_list.GetPinnableReference());
        }

    }
}

