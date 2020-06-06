// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_framebuffer_object")]
    public unsafe partial class ArbFramebufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint framebuffer)
            => ImplBindFramebuffer(target, framebuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindRenderbuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplBindRenderbuffer(target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcX0">
        /// To be added.
        /// </param>
        /// <param name="srcY0">
        /// To be added.
        /// </param>
        /// <param name="srcX1">
        /// To be added.
        /// </param>
        /// <param name="srcY1">
        /// To be added.
        /// </param>
        /// <param name="dstX0">
        /// To be added.
        /// </param>
        /// <param name="dstY0">
        /// To be added.
        /// </param>
        /// <param name="dstX1">
        /// To be added.
        /// </param>
        /// <param name="dstY1">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] ARB filter)
            => ImplBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB CheckFramebufferStatus([Flow(FlowDirection.In)] ARB target)
            => ImplCheckFramebufferStatus(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers)
            => ImplDeleteFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers)
            => ImplDeleteFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers)
            => ImplDeleteRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers)
            => ImplDeleteRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="renderbuffertarget">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferRenderbuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture1D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture2D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture3D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset)
            => ImplFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTextureLayer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplFramebufferTextureLayer(target, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateMipmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateMipmap([Flow(FlowDirection.In)] ARB target)
            => ImplGenerateMipmap(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers)
            => ImplGenFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenFramebuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
            => ImplGenFramebuffers(n, framebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers)
            => ImplGenRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
            => ImplGenRenderbuffers(n, renderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferAttachmentParameter(target, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferAttachmentParameter(target, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetRenderbufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetRenderbufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetRenderbufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer)
            => ImplIsFramebuffer(framebuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer)
            => ImplIsRenderbuffer(renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorage(target, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisample(target, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer)
            => ImplBindFramebuffer(target, framebuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplBindRenderbuffer(target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcX0">
        /// To be added.
        /// </param>
        /// <param name="srcY0">
        /// To be added.
        /// </param>
        /// <param name="srcX1">
        /// To be added.
        /// </param>
        /// <param name="srcY1">
        /// To be added.
        /// </param>
        /// <param name="dstX0">
        /// To be added.
        /// </param>
        /// <param name="dstY0">
        /// To be added.
        /// </param>
        /// <param name="dstX1">
        /// To be added.
        /// </param>
        /// <param name="dstY1">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter)
            => ImplBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target)
            => ImplCheckFramebufferStatus(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="renderbuffertarget">
        /// To be added.
        /// </param>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture1D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture2D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="textarget">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset)
            => ImplFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplFramebufferTextureLayer(target, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateMipmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target)
            => ImplGenerateMipmap(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferAttachmentParameter(target, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferAttachmentParameter(target, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetRenderbufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetRenderbufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorage(target, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisample(target, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public ArbFramebufferObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

