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
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTexture2DDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerDownsampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayerDownsample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int xscale, [Flow(FlowDirection.In)] int yscale);

        public ImgFramebufferDownsample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

