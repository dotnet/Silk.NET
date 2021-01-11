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
    [Extension("KHR_stream_consumer_gltexture")]
    public unsafe partial class KhrStreamConsumerGltexture : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_consumer_gltexture";
        [NativeApi(EntryPoint = "eglStreamConsumerAcquireKHR")]
        public partial int StreamConsumerAcquire([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalKHR")]
        public partial int StreamConsumerGltextureExternal([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseKHR")]
        public partial int StreamConsumerRelease([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream);

        public KhrStreamConsumerGltexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

