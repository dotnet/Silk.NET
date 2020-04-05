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
    [Extension("WL_create_wayland_buffer_from_image")]
    public abstract unsafe partial class WLCreateWaylandBufferFromImage : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateWaylandBufferFromImageWL")]
        public abstract unsafe IntPtr* CreateWaylandBufferFromImageWL([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image);

        public unsafe IntPtr* CreateWaylandBufferFromImageWL([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            return CreateWaylandBufferFromImageWL(new IntPtr(dpy), new IntPtr(image));
        }

        public WLCreateWaylandBufferFromImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

