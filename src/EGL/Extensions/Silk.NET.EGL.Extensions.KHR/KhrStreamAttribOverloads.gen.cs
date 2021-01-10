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

namespace Silk.NET.EGL.Extensions.KHR
{
    public static class KhrStreamAttribOverloads
    {
        public static unsafe nint CreateStreamAttrib(this KhrStreamAttrib thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateStreamAttrib(dpy, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool QueryStreamAttrib(this KhrStreamAttrib thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryStreamAttrib(dpy, stream, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool StreamConsumerAcquireAttrib(this KhrStreamAttrib thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamConsumerAcquireAttrib(dpy, stream, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool StreamConsumerReleaseAttrib(this KhrStreamAttrib thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamConsumerReleaseAttrib(dpy, stream, in attrib_list.GetPinnableReference());
        }

    }
}

