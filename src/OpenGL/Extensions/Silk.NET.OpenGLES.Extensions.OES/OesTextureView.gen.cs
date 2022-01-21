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
    [Extension("OES_texture_view")]
    public unsafe partial class OesTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_view";
        [NativeApi(EntryPoint = "glTextureViewOES", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewOES", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewOES", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewOES", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        public OesTextureView(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

