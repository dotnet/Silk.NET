// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_EGL_image")]
    public unsafe partial class OesEglImage : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_EGL_image";
        [NativeApi(EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
        public partial void EglimageTargetRenderbufferStorage([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image);

        [NativeApi(EntryPoint = "glEGLImageTargetTexture2DOES")]
        public partial void EglimageTargetTexture2D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image);

        public OesEglImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

