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
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glFramebufferTexture2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        public ExtMultisampledRenderToTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

