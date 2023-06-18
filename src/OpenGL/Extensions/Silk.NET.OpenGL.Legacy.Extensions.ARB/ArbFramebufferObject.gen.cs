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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_framebuffer_object")]
    public unsafe partial class ArbFramebufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_object";
        [NativeApi(EntryPoint = "glBindFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glIsFramebuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        public ArbFramebufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

