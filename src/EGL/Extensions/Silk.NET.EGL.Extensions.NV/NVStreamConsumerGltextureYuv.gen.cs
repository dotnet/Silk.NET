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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_stream_consumer_gltexture_yuv")]
    public unsafe partial class NVStreamConsumerGltextureYuv : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_consumer_gltexture_yuv";
        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV")]
        public unsafe partial int StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV")]
        public partial int StreamConsumerGltextureExternalAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] in nint attrib_list);

        public NVStreamConsumerGltextureYuv(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

