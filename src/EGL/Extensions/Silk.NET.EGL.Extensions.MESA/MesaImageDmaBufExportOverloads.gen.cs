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
    public static class MesaImageDmaBufExportOverloads
    {
        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, strides, out offsets.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, out strides.GetPinnableReference(), offsets);
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, out strides.GetPinnableReference(), out offsets.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), strides, offsets);
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), strides, out offsets.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), out strides.GetPinnableReference(), offsets);
        }

        public static unsafe int ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), out strides.GetPinnableReference(), out offsets.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, num_planes, out modifiers.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, out num_planes.GetPinnableReference(), modifiers);
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, out num_planes.GetPinnableReference(), out modifiers.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), num_planes, modifiers);
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), num_planes, out modifiers.GetPinnableReference());
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), out num_planes.GetPinnableReference(), modifiers);
        }

        public static unsafe int ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), out num_planes.GetPinnableReference(), out modifiers.GetPinnableReference());
        }

    }
}

