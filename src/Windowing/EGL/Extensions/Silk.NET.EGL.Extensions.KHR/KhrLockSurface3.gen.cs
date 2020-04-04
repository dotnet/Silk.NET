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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_lock_surface3")]
    public abstract unsafe partial class KhrLockSurface3 : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public abstract unsafe bool LockSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public abstract bool LockSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQuerySurface64KHR")]
        public abstract unsafe bool QuerySurface64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQuerySurface64KHR")]
        public abstract bool QuerySurface64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglUnlockSurfaceKHR")]
        public abstract bool UnlockSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface);

        public unsafe bool LockSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return LockSurface(new IntPtr(dpy), new IntPtr(surface), attrib_list);
        }

        public unsafe bool LockSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return LockSurface(new IntPtr(dpy), new IntPtr(surface), attrib_list);
        }

        public unsafe bool QuerySurface64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QuerySurface64(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public unsafe bool QuerySurface64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QuerySurface64(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public unsafe bool UnlockSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return UnlockSurface(new IntPtr(dpy), new IntPtr(surface));
        }

        public KhrLockSurface3(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

