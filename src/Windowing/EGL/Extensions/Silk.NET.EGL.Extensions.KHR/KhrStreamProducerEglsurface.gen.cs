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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream_producer_eglsurface")]
    public abstract unsafe partial class KhrStreamProducerEglsurface : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_producer_eglsurface";
        [NativeApi(EntryPoint = "eglCreateStreamProducerSurfaceKHR")]
        public abstract unsafe IntPtr CreateStreamProducerSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamProducerSurfaceKHR")]
        public abstract IntPtr CreateStreamProducerSurface([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr config, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] Span<int> attrib_list);

        public unsafe IntPtr CreateStreamProducerSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamProducerSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(stream), attrib_list);
        }

        public unsafe IntPtr CreateStreamProducerSurface([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int config, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamProducerSurface(new IntPtr(dpy), new IntPtr(config), new IntPtr(stream), attrib_list);
        }

        public KhrStreamProducerEglsurface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

