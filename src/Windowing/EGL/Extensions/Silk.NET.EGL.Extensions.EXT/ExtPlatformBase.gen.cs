// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_platform_base")]
    public abstract unsafe partial class ExtPlatformBase : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public abstract unsafe IntPtr CreatePlatformPixmapSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public abstract IntPtr CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] Span<int> attrib_list) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public abstract unsafe IntPtr CreatePlatformWindowSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public abstract IntPtr CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] Span<int> attrib_list) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public abstract unsafe IntPtr GetPlatformDisplay([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public abstract IntPtr GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] Span<T0> native_display, [Flow(FlowDirection.In)] Span<int> attrib_list) where T0 : unmanaged;

        public unsafe IntPtr CreatePlatformPixmapSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreatePlatformPixmapSurface(new IntPtr(dpy), new IntPtr(config), native_pixmap, attrib_list);
        }

        public unsafe IntPtr CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] Span<T0> native_pixmap, [Flow(FlowDirection.In)] Span<int> attrib_list) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreatePlatformPixmapSurface(new IntPtr(dpy), new IntPtr(config), native_pixmap, attrib_list);
        }

        public unsafe IntPtr CreatePlatformWindowSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreatePlatformWindowSurface(new IntPtr(dpy), new IntPtr(config), native_window, attrib_list);
        }

        public unsafe IntPtr CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] Span<T0> native_window, [Flow(FlowDirection.In)] Span<int> attrib_list) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreatePlatformWindowSurface(new IntPtr(dpy), new IntPtr(config), native_window, attrib_list);
        }

        public ExtPlatformBase(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

