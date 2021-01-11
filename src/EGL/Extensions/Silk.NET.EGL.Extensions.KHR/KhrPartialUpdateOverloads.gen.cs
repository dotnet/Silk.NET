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
    public static class KhrPartialUpdateOverloads
    {
        public static unsafe int SetDamageRegion(this KhrPartialUpdate thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.Out)] Span<int> rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // SpanOverloader
            return thisApi.SetDamageRegion(dpy, surface, out rects.GetPinnableReference(), n_rects);
        }

    }
}

