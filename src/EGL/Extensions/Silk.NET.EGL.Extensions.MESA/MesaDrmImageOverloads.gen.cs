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

namespace Silk.NET.EGL.Extensions.MESA
{
    public static class MesaDrmImageOverloads
    {
        public static unsafe nint CreateDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateDrmimage(dpy, in attrib_list.GetPinnableReference());
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, handle, out stride.GetPinnableReference());
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, out handle.GetPinnableReference(), stride);
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, out handle.GetPinnableReference(), out stride.GetPinnableReference());
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), handle, stride);
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), handle, out stride.GetPinnableReference());
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), out handle.GetPinnableReference(), stride);
        }

        public static unsafe int ExportDrmimage(this MesaDrmImage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), out handle.GetPinnableReference(), out stride.GetPinnableReference());
        }

    }
}

