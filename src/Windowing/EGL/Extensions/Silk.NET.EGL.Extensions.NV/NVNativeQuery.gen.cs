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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_native_query")]
    public abstract unsafe partial class NVNativeQuery : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV")]
        public abstract unsafe bool QueryNativeDisplay([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] IntPtr* display_id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV")]
        public abstract bool QueryNativeDisplay([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display_id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativePixmapNV")]
        public abstract unsafe bool QueryNativePixmap([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surf, [Flow(FlowDirection.Out)] IntPtr* pixmap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativePixmapNV")]
        public abstract bool QueryNativePixmap([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surf, [Flow(FlowDirection.Out)] Span<IntPtr> pixmap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativeWindowNV")]
        public abstract unsafe bool QueryNativeWindow([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surf, [Flow(FlowDirection.Out)] IntPtr* window);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryNativeWindowNV")]
        public abstract bool QueryNativeWindow([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surf, [Flow(FlowDirection.Out)] Span<IntPtr> window);

        public unsafe bool QueryNativeDisplay([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] IntPtr* display_id)
        {
            // IntPtrOverloader
            return QueryNativeDisplay(new IntPtr(dpy), display_id);
        }

        public unsafe bool QueryNativeDisplay([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display_id)
        {
            // IntPtrOverloader
            return QueryNativeDisplay(new IntPtr(dpy), display_id);
        }

        public unsafe bool QueryNativePixmap([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surf, [Flow(FlowDirection.Out)] IntPtr* pixmap)
        {
            // IntPtrOverloader
            return QueryNativePixmap(new IntPtr(dpy), new IntPtr(surf), pixmap);
        }

        public unsafe bool QueryNativePixmap([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surf, [Flow(FlowDirection.Out)] Span<IntPtr> pixmap)
        {
            // IntPtrOverloader
            return QueryNativePixmap(new IntPtr(dpy), new IntPtr(surf), pixmap);
        }

        public unsafe bool QueryNativeWindow([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surf, [Flow(FlowDirection.Out)] IntPtr* window)
        {
            // IntPtrOverloader
            return QueryNativeWindow(new IntPtr(dpy), new IntPtr(surf), window);
        }

        public unsafe bool QueryNativeWindow([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surf, [Flow(FlowDirection.Out)] Span<IntPtr> window)
        {
            // IntPtrOverloader
            return QueryNativeWindow(new IntPtr(dpy), new IntPtr(surf), window);
        }

        public NVNativeQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

