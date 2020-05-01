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

namespace Silk.NET.EGL.Extensions.ANGLE
{
    [Extension("ANGLE_query_surface_pointer")]
    public abstract unsafe partial class AngleQuerySurfacePointer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANGLE_query_surface_pointer";
        [NativeApi(EntryPoint = "eglQuerySurfacePointerANGLE")]
        public abstract unsafe bool QuerySurfacePointer([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] void** value);

        public unsafe bool QuerySurfacePointer([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] void** value)
        {
            // IntPtrOverloader
            return QuerySurfacePointer(new IntPtr(dpy), new IntPtr(surface), attribute, value);
        }

        public AngleQuerySurfacePointer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

