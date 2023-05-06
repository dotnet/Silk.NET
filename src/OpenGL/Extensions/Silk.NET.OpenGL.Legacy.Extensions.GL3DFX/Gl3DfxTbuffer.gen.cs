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

namespace Silk.NET.OpenGL.Legacy.Extensions.GL3DFX
{
    [Extension("3DFX_tbuffer")]
    public unsafe partial class Gl3DfxTbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "3DFX_tbuffer";
        [NativeApi(EntryPoint = "glTbufferMask3DFX", Convention = CallingConvention.Winapi)]
        public partial void TbufferMask3Dfx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        public Gl3DfxTbuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

