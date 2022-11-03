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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_texture_array")]
    public unsafe partial class ExtTextureArray : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_array";
        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        public ExtTextureArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

