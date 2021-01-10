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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_platform_base")]
    public unsafe partial class ExtPlatformBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_platform_base";
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public unsafe partial nint CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_pixmap, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT")]
        public partial nint CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_pixmap, [Flow(FlowDirection.In)] in int attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public unsafe partial nint CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_window, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT")]
        public partial nint CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_window, [Flow(FlowDirection.In)] in int attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public unsafe partial nint GetPlatformDisplay([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public unsafe partial nint GetPlatformDisplay([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public unsafe partial nint GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] out T0 native_display, [Flow(FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT")]
        public partial nint GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EXT platform, [Flow(FlowDirection.Out)] out T0 native_display, [Flow(FlowDirection.In)] in int attrib_list) where T0 : unmanaged;

        public ExtPlatformBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

