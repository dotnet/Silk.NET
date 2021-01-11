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
    [Extension("KHR_lock_surface")]
    public unsafe partial class KhrLockSurface : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_lock_surface";
        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public unsafe partial int LockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglLockSurfaceKHR")]
        public partial int LockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglUnlockSurfaceKHR")]
        public partial int UnlockSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface);

        public KhrLockSurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

