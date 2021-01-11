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
    public static class NVSyncOverloads
    {
        public static unsafe nint CreateFenceSync(this NVSync thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] NV condition, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateFenceSync(dpy, condition, in attrib_list.GetPinnableReference());
        }

        public static unsafe int GetSyncAttrib(this NVSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.GetSyncAttrib(sync, attribute, out value.GetPinnableReference());
        }

    }
}

