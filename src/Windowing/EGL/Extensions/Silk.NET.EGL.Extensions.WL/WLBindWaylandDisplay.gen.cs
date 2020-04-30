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

namespace Silk.NET.EGL.Extensions.WL
{
    [Extension("WL_bind_wayland_display")]
    public abstract unsafe partial class WLBindWaylandDisplay : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL")]
        public abstract unsafe bool BindWaylandDisplayWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] IntPtr* display);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL")]
        public abstract bool BindWaylandDisplayWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public abstract unsafe bool QueryWaylandBufferWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] IntPtr* buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL")]
        public abstract bool QueryWaylandBufferWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<IntPtr> buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL")]
        public abstract unsafe bool UnbindWaylandDisplayWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] IntPtr* display);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL")]
        public abstract bool UnbindWaylandDisplayWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display);

        public unsafe bool BindWaylandDisplayWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] IntPtr* display)
        {
            // IntPtrOverloader
            return BindWaylandDisplayWL(new IntPtr(dpy), display);
        }

        public unsafe bool BindWaylandDisplayWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display)
        {
            // IntPtrOverloader
            return BindWaylandDisplayWL(new IntPtr(dpy), display);
        }

        public unsafe bool QueryWaylandBufferWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] IntPtr* buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return QueryWaylandBufferWL(new IntPtr(dpy), buffer, attribute, value);
        }

        public unsafe bool QueryWaylandBufferWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<IntPtr> buffer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return QueryWaylandBufferWL(new IntPtr(dpy), buffer, attribute, value);
        }

        public unsafe bool UnbindWaylandDisplayWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] IntPtr* display)
        {
            // IntPtrOverloader
            return UnbindWaylandDisplayWL(new IntPtr(dpy), display);
        }

        public unsafe bool UnbindWaylandDisplayWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.Out)] Span<IntPtr> display)
        {
            // IntPtrOverloader
            return UnbindWaylandDisplayWL(new IntPtr(dpy), display);
        }

        public WLBindWaylandDisplay(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

