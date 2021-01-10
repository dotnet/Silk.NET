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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_lock_surface3")]
    public unsafe partial class KhrLockSurface3 : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_lock_surface3";
        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public unsafe partial bool LockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public partial bool LockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglQuerySurface64KHR")]
        public unsafe partial bool QuerySurface64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQuerySurface64KHR")]
        public partial bool QuerySurface64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglUnlockSurfaceKHR")]
        public partial bool UnlockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface);

        public KhrLockSurface3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

