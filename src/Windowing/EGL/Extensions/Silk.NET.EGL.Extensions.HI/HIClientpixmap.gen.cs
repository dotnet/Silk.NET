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

namespace Silk.NET.EGL.Extensions.HI
{
    [Extension("HI_clientpixmap")]
    public abstract unsafe partial class HIClientpixmap : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI")]
        public abstract unsafe IntPtr CreatePixmapSurfaceHI([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] IntPtr* pixmap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI")]
        public abstract IntPtr CreatePixmapSurfaceHI([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.Out)] Span<IntPtr> pixmap);

        public unsafe IntPtr CreatePixmapSurfaceHI([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] IntPtr* pixmap)
        {
            // IntPtrOverloader
            return CreatePixmapSurfaceHI(new IntPtr(dpy), new IntPtr(config), pixmap);
        }

        public unsafe IntPtr CreatePixmapSurfaceHI([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.Out)] Span<IntPtr> pixmap)
        {
            // IntPtrOverloader
            return CreatePixmapSurfaceHI(new IntPtr(dpy), new IntPtr(config), pixmap);
        }

        public HIClientpixmap(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

