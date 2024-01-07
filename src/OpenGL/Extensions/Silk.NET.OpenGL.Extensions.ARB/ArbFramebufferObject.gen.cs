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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_framebuffer_object")]
    public unsafe partial class ArbFramebufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_object";
        [NativeApi(EntryPoint = "glBindFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearBufferMask mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glBlitFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearBufferMask mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void DeleteFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void DeleteRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3D", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glGenerateMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFramebuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial bool IsRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        public unsafe void DeleteFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> framebuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteFramebuffers((uint) framebuffers.Length, in framebuffers.GetPinnableReference());
        }

        public unsafe void DeleteFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Framebuffer> framebuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteFramebuffers((uint) framebuffers.Length, in framebuffers.GetPinnableReference());
        }

        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        public unsafe void DeleteRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteRenderbuffers((uint) renderbuffers.Length, in renderbuffers.GetPinnableReference());
        }

        public unsafe void DeleteRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Renderbuffer> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteRenderbuffers((uint) renderbuffers.Length, in renderbuffers.GetPinnableReference());
        }

        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        public unsafe void GenFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers)
        {
            // ImplicitCountSpanOverloader
            GenFramebuffers((uint) framebuffers.Length, out framebuffers.GetPinnableReference());
        }

        public unsafe void GenFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers)
        {
            // ImplicitCountSpanOverloader
            GenFramebuffers((uint) framebuffers.Length, out framebuffers.GetPinnableReference());
        }

        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe void GenRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            GenRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public unsafe void GenRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            GenRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public unsafe uint GenFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenFramebuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GenRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenRenderbuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferAttachmentParameter(target, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetRenderbufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetRenderbufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetRenderbufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetRenderbufferParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public ArbFramebufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

