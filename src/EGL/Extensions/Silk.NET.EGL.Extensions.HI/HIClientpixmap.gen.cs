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

namespace Silk.NET.EGL.Extensions.HI
{
    [Extension("HI_clientpixmap")]
    public unsafe partial class HIClientpixmap : NativeExtension<EGL>
    {
        public const string ExtensionName = "HI_clientpixmap";
        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI")]
        public unsafe partial nint CreatePixmapSurfaceHI([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] ClientPixmapHI* pixmap);

        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI")]
        public partial nint CreatePixmapSurfaceHI([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out ClientPixmapHI pixmap);

        public HIClientpixmap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

