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
    [Extension("WL_bind_wayland_display")]
    public unsafe partial class WLBindWaylandDisplay : NativeExtension<EGL>
    {
        public const string ExtensionName = "WL_bind_wayland_display";
        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL")]
        public unsafe partial int BindWaylandDisplayWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* display);

        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL")]
        public partial int BindWaylandDisplayWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint display);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public unsafe partial int QueryWaylandBufferWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public unsafe partial int QueryWaylandBufferWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public unsafe partial int QueryWaylandBufferWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public partial int QueryWaylandBufferWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL")]
        public unsafe partial int UnbindWaylandDisplayWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* display);

        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL")]
        public partial int UnbindWaylandDisplayWL([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint display);

        public WLBindWaylandDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

