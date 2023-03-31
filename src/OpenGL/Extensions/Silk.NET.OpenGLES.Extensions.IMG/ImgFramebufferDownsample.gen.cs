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

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [Extension("IMG_framebuffer_downsample")]
    public unsafe partial class ImgFramebufferDownsample : NativeExtension<GL>
    {
        public const string ExtensionName = "IMG_framebuffer_downsample";
        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xscale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yscale);

        public ImgFramebufferDownsample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

