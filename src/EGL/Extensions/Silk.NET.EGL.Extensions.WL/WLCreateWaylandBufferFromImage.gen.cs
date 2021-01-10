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

namespace Silk.NET.EGL.Extensions.WL
{
    [Extension("WL_create_wayland_buffer_from_image")]
    public unsafe partial class WLCreateWaylandBufferFromImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "WL_create_wayland_buffer_from_image";
        [NativeApi(EntryPoint = "eglCreateWaylandBufferFromImageWL")]
        public unsafe partial nint* CreateWaylandBufferFromImageWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image);

        public WLCreateWaylandBufferFromImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

