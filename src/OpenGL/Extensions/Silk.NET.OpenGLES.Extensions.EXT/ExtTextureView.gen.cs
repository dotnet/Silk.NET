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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_view")]
    public unsafe partial class ExtTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_view";
        [NativeApi(EntryPoint = "glTextureViewEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint origtexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint origtexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint origtexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureView([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint origtexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlevels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint minlayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numlayers);

        public ExtTextureView(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

