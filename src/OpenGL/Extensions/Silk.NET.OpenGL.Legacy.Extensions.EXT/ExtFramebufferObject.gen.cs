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
        public partial void BindFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindFramebufferEXT", Convention = CallingConvention.Winapi)]
        public partial void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glCheckFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckFramebufferStatus([Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glCheckFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glGenerateMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenerateMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGenFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFramebufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        public unsafe void DeleteFramebuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> framebuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteFramebuffers((uint) framebuffers.Length, in framebuffers.GetPinnableReference());
        }

        public unsafe void DeleteFramebuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Framebuffer> framebuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteFramebuffers((uint) framebuffers.Length, in framebuffers.GetPinnableReference());
        }

        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        public unsafe void DeleteRenderbuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            DeleteRenderbuffers((uint) renderbuffers.Length, in renderbuffers.GetPinnableReference());
        }

        public unsafe void DeleteRenderbuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Renderbuffer> renderbuffers)
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

        public unsafe void GenFramebuffers([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
        {
            // ImplicitCountSpanOverloader
            GenFramebuffers((uint) framebuffers.Length, out framebuffers.GetPinnableReference());
        }

        public unsafe void GenFramebuffers([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers)
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

        public unsafe void GenRenderbuffers([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            GenRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public unsafe void GenRenderbuffers([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            GenRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public ExtFramebufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

