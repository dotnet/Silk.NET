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
    public static class ExtPlatformBaseOverloads
    {
        public static unsafe nint CreatePlatformPixmapSurface(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, native_pixmap, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, native_window, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, native_display, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint GetPlatformDisplay<T0>(this ExtPlatformBase thisApi, [Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

    }
}

