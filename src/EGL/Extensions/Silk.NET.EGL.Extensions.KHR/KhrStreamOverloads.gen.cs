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
    public static class KhrStreamOverloads
    {
        public static unsafe nint CreateStream(this KhrStream thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateStream(dpy, in attrib_list.GetPinnableReference());
        }

        public static unsafe int QueryStream(this KhrStream thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryStream(dpy, stream, attribute, out value.GetPinnableReference());
        }

        public static unsafe int QueryStreamu64(this KhrStream thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<ulong> value)
        {
            // SpanOverloader
            return thisApi.QueryStreamu64(dpy, stream, attribute, out value.GetPinnableReference());
        }

    }
}

