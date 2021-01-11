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

namespace Silk.NET.EGL.Extensions.ANGLE
{
    [Extension("ANGLE_query_surface_pointer")]
    public unsafe partial class AngleQuerySurfacePointer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANGLE_query_surface_pointer";
        [NativeApi(EntryPoint = "eglQuerySurfacePointerANGLE")]
        public unsafe partial int QuerySurfacePointer([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] void** value);

        [NativeApi(EntryPoint = "eglQuerySurfacePointerANGLE")]
        public unsafe partial int QuerySurfacePointer([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out void* value);

        public AngleQuerySurfacePointer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

