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

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_lock_surface")]
    public abstract unsafe partial class KhrLockSurface : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_lock_surface";
        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public abstract unsafe bool LockSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public abstract bool LockSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] Span<int> attrib_list);

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

        public unsafe bool UnlockSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return UnlockSurface(new IntPtr(dpy), new IntPtr(surface));
        }

        public KhrLockSurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

