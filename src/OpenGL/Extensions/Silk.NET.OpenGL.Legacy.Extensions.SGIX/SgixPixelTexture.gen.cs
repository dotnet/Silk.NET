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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_pixel_texture")]
    public unsafe partial class SgixPixelTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_pixel_texture";
        [NativeApi(EntryPoint = "glPixelTexGenSGIX", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glPixelTexGenSGIX", Convention = CallingConvention.Winapi)]
        public partial void PixelTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTexGenModeSGIX mode);

        public SgixPixelTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

