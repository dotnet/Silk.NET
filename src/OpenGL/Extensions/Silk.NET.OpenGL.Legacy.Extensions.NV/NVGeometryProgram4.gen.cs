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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_geometry_program4")]
    public unsafe partial class NVGeometryProgram4 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_geometry_program4";
        [NativeApi(EntryPoint = "glFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] NV face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] NV face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] NV face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] NV face);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureFace([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glProgramVertexLimitNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramVertexLimit([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] int limit);

        [NativeApi(EntryPoint = "glProgramVertexLimitNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramVertexLimit([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] int limit);

        public NVGeometryProgram4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

