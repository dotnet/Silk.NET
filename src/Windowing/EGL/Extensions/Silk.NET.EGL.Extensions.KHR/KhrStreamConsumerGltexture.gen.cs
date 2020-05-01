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
    [Extension("KHR_stream_consumer_gltexture")]
    public abstract unsafe partial class KhrStreamConsumerGltexture : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_consumer_gltexture";
        [NativeApi(EntryPoint = "eglStreamConsumerAcquireKHR")]
        public abstract bool StreamConsumerAcquire([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalKHR")]
        public abstract bool StreamConsumerGltextureExternal([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseKHR")]
        public abstract bool StreamConsumerRelease([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        public unsafe bool StreamConsumerAcquire([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return StreamConsumerAcquire(new IntPtr(dpy), new IntPtr(stream));
        }

        public unsafe bool StreamConsumerGltextureExternal([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return StreamConsumerGltextureExternal(new IntPtr(dpy), new IntPtr(stream));
        }

        public unsafe bool StreamConsumerRelease([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return StreamConsumerRelease(new IntPtr(dpy), new IntPtr(stream));
        }

        public KhrStreamConsumerGltexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

