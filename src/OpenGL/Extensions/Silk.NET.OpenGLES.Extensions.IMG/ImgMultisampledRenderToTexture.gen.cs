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
    [Extension("IMG_multisampled_render_to_texture")]
    public unsafe partial class ImgMultisampledRenderToTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "IMG_multisampled_render_to_texture";
        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] IMG attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] IMG textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] IMG internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] IMG target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] IMG internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleIMG", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public ImgMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

