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
    public static class NVNativeQueryOverloads
    {
        public static unsafe int QueryNativeDisplay(this NVNativeQuery thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> display_id)
        {
            // SpanOverloader
            return thisApi.QueryNativeDisplay(dpy, out display_id.GetPinnableReference());
        }

        public static unsafe int QueryNativePixmap(this NVNativeQuery thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] Span<nint> pixmap)
        {
            // SpanOverloader
            return thisApi.QueryNativePixmap(dpy, surf, out pixmap.GetPinnableReference());
        }

        public static unsafe int QueryNativeWindow(this NVNativeQuery thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] Span<nint> window)
        {
            // SpanOverloader
            return thisApi.QueryNativeWindow(dpy, surf, out window.GetPinnableReference());
        }

    }
}

