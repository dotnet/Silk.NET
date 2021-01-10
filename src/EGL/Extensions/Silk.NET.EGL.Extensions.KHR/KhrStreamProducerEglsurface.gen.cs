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
    [Extension("KHR_stream_producer_eglsurface")]
    public unsafe partial class KhrStreamProducerEglsurface : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_producer_eglsurface";
        [NativeApi(EntryPoint = "eglCreateStreamProducerSurfaceKHR")]
        public unsafe partial nint CreateStreamProducerSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamProducerSurfaceKHR")]
        public partial nint CreateStreamProducerSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] in int attrib_list);

        public KhrStreamProducerEglsurface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

