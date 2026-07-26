// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_EGL_image_external")]
    public unsafe partial class OesEglImageExternal : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_EGL_image_external";
        [NativeApi(EntryPoint = "glEGLImageTargetTexture2DOES", Convention = CallingConvention.Winapi)]
        public partial void EglimageTargetTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image);

        public OesEglImageExternal(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

