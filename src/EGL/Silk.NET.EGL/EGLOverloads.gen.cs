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

namespace Silk.NET.EGL
{
    public static class EGLOverloads
    {
        public static unsafe nint CreateImage(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateImage(dpy, ctx, target, buffer, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformPixmapSurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, native_pixmap, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, native_window, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreateSync(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateSync(dpy, type, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay(this EGL thisApi, [Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, native_display, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay<T0>(this EGL thisApi, [Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint GetPlatformDisplay<T0>(this EGL thisApi, [Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe int GetSyncAttrib(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.GetSyncAttrib(dpy, sync, attribute, out value.GetPinnableReference());
        }

        public static unsafe nint CreatePbufferFromClientBuffer(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePbufferFromClientBuffer(dpy, buftype, buffer, config, in attrib_list.GetPinnableReference());
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, attrib_list, configs, config_size, out num_config.GetPinnableReference());
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, attrib_list, out configs.GetPinnableReference(), config_size, num_config);
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, attrib_list, out configs.GetPinnableReference(), config_size, out num_config.GetPinnableReference());
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, in attrib_list.GetPinnableReference(), configs, config_size, num_config);
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, in attrib_list.GetPinnableReference(), configs, config_size, out num_config.GetPinnableReference());
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, in attrib_list.GetPinnableReference(), out configs.GetPinnableReference(), config_size, num_config);
        }

        public static unsafe int ChooseConfig(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.ChooseConfig(dpy, in attrib_list.GetPinnableReference(), out configs.GetPinnableReference(), config_size, out num_config.GetPinnableReference());
        }

        public static unsafe nint CreateContext(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint share_context, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateContext(dpy, config, share_context, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePbufferSurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePbufferSurface(dpy, config, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePixmapSurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint pixmap, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePixmapSurface(dpy, config, pixmap, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreateWindowSurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint win, [Flow(FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateWindowSurface(dpy, config, win, in attrib_list.GetPinnableReference());
        }

        public static unsafe int GetConfigAttrib(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.GetConfigAttrib(dpy, config, attribute, out value.GetPinnableReference());
        }

        public static unsafe int GetConfigs(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.GetConfigs(dpy, configs, config_size, out num_config.GetPinnableReference());
        }

        public static unsafe int GetConfigs(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config)
        {
            // SpanOverloader
            return thisApi.GetConfigs(dpy, out configs.GetPinnableReference(), config_size, num_config);
        }

        public static unsafe int GetConfigs(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<nint> configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] Span<int> num_config)
        {
            // SpanOverloader
            return thisApi.GetConfigs(dpy, out configs.GetPinnableReference(), config_size, out num_config.GetPinnableReference());
        }

        public static unsafe void* GetProcAddress(this EGL thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> procname)
        {
            // SpanOverloader
            return thisApi.GetProcAddress(in procname.GetPinnableReference());
        }

        public static unsafe int Initialize(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] int* major, [Flow(FlowDirection.Out)] Span<int> minor)
        {
            // SpanOverloader
            return thisApi.Initialize(dpy, major, out minor.GetPinnableReference());
        }

        public static unsafe int Initialize(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<int> major, [Flow(FlowDirection.Out)] int* minor)
        {
            // SpanOverloader
            return thisApi.Initialize(dpy, out major.GetPinnableReference(), minor);
        }

        public static unsafe int Initialize(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] Span<int> major, [Flow(FlowDirection.Out)] Span<int> minor)
        {
            // SpanOverloader
            return thisApi.Initialize(dpy, out major.GetPinnableReference(), out minor.GetPinnableReference());
        }

        public static unsafe int QueryContext(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryContext(dpy, ctx, attribute, out value.GetPinnableReference());
        }

        public static unsafe int QuerySurface(this EGL thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QuerySurface(dpy, surface, attribute, out value.GetPinnableReference());
        }

    }
}

