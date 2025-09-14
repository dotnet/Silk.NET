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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_texture_barrier")]
    public unsafe partial class NVTextureBarrier : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_texture_barrier";
        [NativeApi(EntryPoint = "glTextureBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void TextureBarrier();

        public NVTextureBarrier(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

