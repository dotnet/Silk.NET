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

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtImageDmaBufImportModifiersOverloads
    {
        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] int* formats, [Flow(FlowDirection.Out)] Span<int> num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, formats, out num_formats.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] Span<int> formats, [Flow(FlowDirection.Out)] int* num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, out formats.GetPinnableReference(), num_formats);
        }

        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] Span<int> formats, [Flow(FlowDirection.Out)] Span<int> num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, out formats.GetPinnableReference(), out num_formats.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] bool* external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, external_only, out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, out external_only.GetPinnableReference(), num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, out external_only.GetPinnableReference(), out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] bool* external_only, [Flow(FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), external_only, num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] bool* external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), external_only, out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), out external_only.GetPinnableReference(), num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), out external_only.GetPinnableReference(), out num_modifiers.GetPinnableReference());
        }

    }
}

