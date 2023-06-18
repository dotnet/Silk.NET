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
    [Extension("EXT_framebuffer_object")]
    public unsafe partial class ExtFramebufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_framebuffer_object";
        [NativeApi(EntryPoint = "glBindFramebufferEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glCheckFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glGenerateMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glIsFramebufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        public ExtFramebufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

