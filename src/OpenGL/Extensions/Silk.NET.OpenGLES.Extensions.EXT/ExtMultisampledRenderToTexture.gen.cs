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
    [Extension("EXT_multisampled_render_to_texture")]
    public unsafe partial class ExtMultisampledRenderToTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multisampled_render_to_texture";
        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public ExtMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

