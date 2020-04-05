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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_stream_consumer_gltexture_yuv")]
    public abstract unsafe partial class NVStreamConsumerGltextureYuv : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV")]
        public abstract unsafe bool StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV")]
        public abstract bool StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        public unsafe bool StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerGltextureExternalAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public unsafe bool StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerGltextureExternalAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public NVStreamConsumerGltextureYuv(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

