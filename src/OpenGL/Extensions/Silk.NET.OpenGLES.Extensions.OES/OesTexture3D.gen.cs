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
    [Extension("OES_texture_3D")]
    public unsafe partial class OesTexture3D : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_3D";
        [NativeApi(EntryPoint = "glCompressedTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCopyTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public partial void CopyTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glFramebufferTexture3DOES", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glTexImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3DOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        public OesTexture3D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

