// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public unsafe partial class GL : NativeAPI
    {

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveTexture([Flow(FlowDirection.In)] GLEnum texture)
            => ImplActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shader">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAttachShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AttachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader)
            => ImplAttachShader(program, shader);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name)
            => ImplBindAttribLocation(program, index, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name)
            => ImplBindAttribLocation(program, index, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBuffer(target, buffer);

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
        public void BindFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint framebuffer)
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
        public void BindRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint renderbuffer)
            => ImplBindRenderbuffer(target, renderbuffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint texture)
            => ImplBindTexture(target, texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendColor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha)
            => ImplBlendColor(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] GLEnum mode)
            => ImplBlendEquation(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha)
            => ImplBlendEquationSeparate(modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactor">
        /// To be added.
        /// </param>
        /// <param name="dfactor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] GLEnum dfactor)
            => ImplBlendFunc(sfactor, dfactor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="dfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="sfactorAlpha">
        /// To be added.
        /// </param>
        /// <param name="dfactorAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha)
            => ImplBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
            => ImplBufferData(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
            => ImplBufferData<T0>(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
            => ImplBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] GLEnum target)
            => ImplCheckFramebufferStatus(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClear")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Clear([Flow(FlowDirection.In)] uint mask)
            => ImplClear(mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearColor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha)
            => ImplClearColor(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="d">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearDepth([Flow(FlowDirection.In)] float d)
            => ImplClearDepth(d);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearStencil")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearStencil([Flow(FlowDirection.In)] int s)
            => ImplClearStencil(s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha)
            => ImplColorMask(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompileShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompileShader([Flow(FlowDirection.In)] uint shader)
            => ImplCompileShader(shader);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexImage2D<T0>(target, level, internalformat, width, height, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexSubImage2D<T0>(target, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyTexImage2D(target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateProgram()
            => ImplCreateProgram();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateShader([Flow(FlowDirection.In)] GLEnum type)
            => ImplCreateShader(type);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCullFace")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullFace([Flow(FlowDirection.In)] GLEnum mode)
            => ImplCullFace(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers)
            => ImplDeleteBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers)
            => ImplDeleteBuffers(n, buffers);

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
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteProgram([Flow(FlowDirection.In)] uint program)
            => ImplDeleteProgram(program);

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
        /// <param name="shader">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteShader([Flow(FlowDirection.In)] uint shader)
            => ImplDeleteShader(shader);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures)
            => ImplDeleteTextures(n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures)
            => ImplDeleteTextures(n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthFunc([Flow(FlowDirection.In)] GLEnum func)
            => ImplDepthFunc(func);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="flag">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthMask([Flow(FlowDirection.In)] bool flag)
            => ImplDepthMask(flag);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthRangef")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f)
            => ImplDepthRange(n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shader">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDetachShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DetachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader)
            => ImplDetachShader(program, shader);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] GLEnum cap)
            => ImplDisable(cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableVertexAttribArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index)
            => ImplDisableVertexAttribArray(index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count)
            => ImplDrawArrays(mode, first, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices)
            => ImplDrawElements(mode, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged
            => ImplDrawElements<T0>(mode, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] GLEnum cap)
            => ImplEnable(cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableVertexAttribArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index)
            => ImplEnableVertexAttribArray(index);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glFinish")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Finish()
            => ImplFinish();

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glFlush")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Flush()
            => ImplFlush();

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
        public void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer)
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
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture2D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFrontFace")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FrontFace([Flow(FlowDirection.In)] GLEnum mode)
            => ImplFrontFace(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers)
            => ImplGenBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
            => ImplGenBuffers(n, buffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGenerateMipmap")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenerateMipmap([Flow(FlowDirection.In)] GLEnum target)
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
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures)
            => ImplGenTextures(n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenTextures")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
            => ImplGenTextures(n, textures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveAttrib(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetActiveAttrib(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveUniform(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetActiveUniform(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="maxCount">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from maxCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders)
            => ImplGetAttachedShaders(program, maxCount, count, shaders);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="maxCount">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from maxCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders)
            => ImplGetAttachedShaders(program, maxCount, count, shaders);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name)
            => ImplGetAttribLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetAttribLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBoolean(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBoolean(pname, data);

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
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetError")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public GLEnum GetError()
            => ImplGetError();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data)
            => ImplGetFloat(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data)
            => ImplGetFloat(pname, data);

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
        public unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        public void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferAttachmentParameter(target, attachment, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInteger(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInteger(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgram(program, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgram(program, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog)
            => ImplGetProgramInfoLog(program, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog)
            => ImplGetProgramInfoLog(program, bufSize, length, infoLog);

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
        public unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        public void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetRenderbufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetShader(shader, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetShader(shader, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog)
            => ImplGetShaderInfoLog(shader, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog)
            => ImplGetShaderInfoLog(shader, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* source)
            => ImplGetShaderSource(shader, bufSize, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> source)
            => ImplGetShaderSource(shader, bufSize, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetString")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name)
            => ImplGetString(name);

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
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name)
            => ImplGetUniformLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetUniformLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer)
            => ImplGetVertexAttribPointer(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged
            => ImplGetVertexAttribPointer<T0>(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHint")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum mode)
            => ImplHint(target, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplIsBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabled")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] GLEnum cap)
            => ImplIsEnabled(cap);

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
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsProgram([Flow(FlowDirection.In)] uint program)
            => ImplIsProgram(program);

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
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsShader([Flow(FlowDirection.In)] uint shader)
            => ImplIsShader(shader);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsTexture([Flow(FlowDirection.In)] uint texture)
            => ImplIsTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLineWidth")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LineWidth([Flow(FlowDirection.In)] float width)
            => ImplLineWidth(width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLinkProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LinkProgram([Flow(FlowDirection.In)] uint program)
            => ImplLinkProgram(program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelStorei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelStore(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="units">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPolygonOffset")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units)
            => ImplPolygonOffset(factor, units);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glReadPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels)
            => ImplReadPixels(x, y, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glReadPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplReadPixels<T0>(x, y, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReleaseShaderCompiler()
            => ImplReleaseShaderCompiler();

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
        public void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorage(target, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="invert">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleCoverage")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert)
            => ImplSampleCoverage(value, invert);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glScissor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Scissor([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplScissor(x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="binaryformat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
            => ImplShaderBinary(count, shaders, binaryformat, binary, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="binaryformat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
            => ImplShaderBinary<T0>(count, shaders, binaryformat, binary, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
            => ImplShaderSource(shader, count, @string, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
            => ImplShaderSource(shader, count, @string, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFunc(func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFuncSeparate(face, func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilMask")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilMask([Flow(FlowDirection.In)] uint mask)
            => ImplStencilMask(mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilMaskSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilMaskSeparate(face, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fail">
        /// To be added.
        /// </param>
        /// <param name="zfail">
        /// To be added.
        /// </param>
        /// <param name="zpass">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOp")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass)
            => ImplStencilOp(fail, zfail, zpass);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="sfail">
        /// To be added.
        /// </param>
        /// <param name="dpfail">
        /// To be added.
        /// </param>
        /// <param name="dppass">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass)
            => ImplStencilOpSeparate(face, sfail, dpfail, dppass);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage2D<T0>(target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param)
            => ImplTexParameter(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param)
            => ImplTexParameter(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage2D<T0>(target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0)
            => ImplUniform1(location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0)
            => ImplUniform1(location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1)
            => ImplUniform2(location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1)
            => ImplUniform2(location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2)
            => ImplUniform3(location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2)
            => ImplUniform3(location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3)
            => ImplUniform4(location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3)
            => ImplUniform4(location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUseProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UseProgram([Flow(FlowDirection.In)] uint program)
            => ImplUseProgram(program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glValidateProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ValidateProgram([Flow(FlowDirection.In)] uint program)
            => ImplValidateProgram(program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x)
            => ImplVertexAttrib1(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplVertexAttrib2(index, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplVertexAttrib3(index, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplVertexAttrib4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribPointer(index, size, type, normalized, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribPointer<T0>(index, size, type, normalized, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glViewport")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Viewport([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplViewport(x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture)
            => ImplActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name)
            => ImplBindAttribLocation(program, index, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBuffer(target, buffer);

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
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture)
            => ImplBindTexture(target, texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode)
            => ImplBlendEquation(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha)
            => ImplBlendEquationSeparate(modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactor">
        /// To be added.
        /// </param>
        /// <param name="dfactor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor)
            => ImplBlendFunc(sfactor, dfactor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="dfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="sfactorAlpha">
        /// To be added.
        /// </param>
        /// <param name="dfactorAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha)
            => ImplBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
            => ImplBufferData(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
            => ImplBufferData<T0>(target, size, data, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
            => ImplBufferSubData(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplBufferSubData<T0>(target, offset, size, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target)
            => ImplCheckFramebufferStatus(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexImage2D<T0>(target, level, internalformat, width, height, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexSubImage2D<T0>(target, level, xoffset, yoffset, width, height, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border)
            => ImplCopyTexImage2D(target, level, internalformat, x, y, width, height, border);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShader")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateShader([Flow(FlowDirection.In)] ShaderType type)
            => ImplCreateShader(type);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCullFace")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullFace([Flow(FlowDirection.In)] CullFaceMode mode)
            => ImplCullFace(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthFunc([Flow(FlowDirection.In)] DepthFunction func)
            => ImplDepthFunc(func);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] EnableCap cap)
            => ImplDisable(cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count)
            => ImplDrawArrays(mode, first, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices)
            => ImplDrawElements(mode, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged
            => ImplDrawElements<T0>(mode, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] EnableCap cap)
            => ImplEnable(cap);

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
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture2D(target, attachment, textarget, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFrontFace")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FrontFace([Flow(FlowDirection.In)] FrontFaceDirection mode)
            => ImplFrontFace(mode);

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
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveAttrib(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveAttrib(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveUniform(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveUniform(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplGetAttribLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBoolean(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBoolean(pname, data);

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
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetBufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data)
            => ImplGetFloat(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFloatv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data)
            => ImplGetFloat(pname, data);

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
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInteger(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInteger(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgram(program, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgram(program, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetProgramInfoLog(program, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetProgramInfoLog(program, bufSize, length, infoLog);

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
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetShader(shader, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetShader(shader, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetShaderInfoLog(shader, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetShaderInfoLog(shader, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source)
            => ImplGetShaderSource(shader, bufSize, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSource")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source)
            => ImplGetShaderSource(shader, bufSize, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetString")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public string GetString([Flow(FlowDirection.In)] StringName name)
            => ImplGetString(name);

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
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplGetUniformLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer)
            => ImplGetVertexAttribPointer(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged
            => ImplGetVertexAttribPointer<T0>(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHint")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] HintMode mode)
            => ImplHint(target, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="cap">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabled")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] EnableCap cap)
            => ImplIsEnabled(cap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelStorei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelStore(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glReadPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels)
            => ImplReadPixels(x, y, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glReadPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged
            => ImplReadPixels<T0>(x, y, width, height, format, type, pixels);

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
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFunc")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFunc(func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFuncSeparate(face, func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilMaskSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilMaskSeparate(face, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fail">
        /// To be added.
        /// </param>
        /// <param name="zfail">
        /// To be added.
        /// </param>
        /// <param name="zpass">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOp")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass)
            => ImplStencilOp(fail, zfail, zpass);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="sfail">
        /// To be added.
        /// </param>
        /// <param name="dpfail">
        /// To be added.
        /// </param>
        /// <param name="dppass">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass)
            => ImplStencilOpSeparate(face, sfail, dpfail, dppass);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage2D<T0>(target, level, internalformat, width, height, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param)
            => ImplTexParameter(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplTexParameter(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage2D<T0>(target, level, xoffset, yoffset, width, height, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribPointer(index, size, type, normalized, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribPointer<T0>(index, size, type, normalized, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQuery(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginTransformFeedback([Flow(FlowDirection.In)] GLEnum primitiveMode)
            => ImplBeginTransformFeedback(primitiveMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler)
            => ImplBindSampler(unit, sampler);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTransformFeedback([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id)
            => ImplBindTransformFeedback(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexArray([Flow(FlowDirection.In)] uint array)
            => ImplBindVertexArray(array);

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
        public void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter)
            => ImplBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="stencil">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil)
            => ImplClearBuffer(buffer, drawbuffer, depth, stencil);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glClientWaitSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public GLEnum ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
            => ImplClientWaitSync(sync, flags, timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexImage3D<T0>(target, level, internalformat, width, height, depth, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexSubImage3D<T0>(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids)
            => ImplDeleteQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids)
            => ImplDeleteQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers)
            => ImplDeleteSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers)
            => ImplDeleteSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteSync([Flow(FlowDirection.In)] IntPtr sync)
            => ImplDeleteSync(sync);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids)
            => ImplDeleteTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids)
            => ImplDeleteTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays)
            => ImplDeleteVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays)
            => ImplDeleteVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount)
            => ImplDrawArraysInstanced(mode, first, count, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] GLEnum* bufs)
            => ImplDrawBuffers(n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<GLEnum> bufs)
            => ImplDrawBuffers(n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount)
            => ImplDrawElementsInstanced(mode, count, type, indices, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices)
            => ImplDrawRangeElements(mode, start, end, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged
            => ImplDrawRangeElements<T0>(mode, start, end, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQuery([Flow(FlowDirection.In)] GLEnum target)
            => ImplEndQuery(target);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndTransformFeedback()
            => ImplEndTransformFeedback();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="condition">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFenceSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr FenceSync([Flow(FlowDirection.In)] GLEnum condition, [Flow(FlowDirection.In)] uint flags)
            => ImplFenceSync(condition, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedBufferRange(target, offset, length);

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
        public void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer)
            => ImplFramebufferTextureLayer(target, attachment, texture, level, layer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplGenQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenQueries")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplGenQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGenSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers)
            => ImplGenSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGenSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers)
            => ImplGenSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplGenTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplGenTransformFeedbacks(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays)
            => ImplGenVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
            => ImplGenVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetBufferPointer<T0>(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetFragDataLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetFragDataLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data)
            => ImplGetInteger64(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data)
            => ImplGetInteger64(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetInternalformat(target, internalformat, pname, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetInternalformat(target, internalformat, pname, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary)
            => ImplGetProgramBinary(program, bufSize, length, binaryFormat, binary);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged
            => ImplGetProgramBinary<T0>(program, bufSize, length, binaryFormat, binary);

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
        [NativeApi(EntryPoint = "glGetQueryiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQuery(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetQueryiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStringi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index)
            => ImplGetString(name, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetUniform(program, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] char* uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ref char uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] char** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
            => ImplGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] ref char* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices)
            => ImplGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsQuery([Flow(FlowDirection.In)] uint id)
            => ImplIsQuery(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsSampler([Flow(FlowDirection.In)] uint sampler)
            => ImplIsSampler(sampler);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsSync([Flow(FlowDirection.In)] IntPtr sync)
            => ImplIsSync(sync);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsTransformFeedback([Flow(FlowDirection.In)] uint id)
            => ImplIsTransformFeedback(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsVertexArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsVertexArray([Flow(FlowDirection.In)] uint array)
            => ImplIsVertexArray(array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapBufferRange(target, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PauseTransformFeedback()
            => ImplPauseTransformFeedback();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
            => ImplProgramBinary(program, binaryFormat, binary, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="binaryFormat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBinary")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
            => ImplProgramBinary<T0>(program, binaryFormat, binary, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value)
            => ImplProgramParameter(program, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="src">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadBuffer([Flow(FlowDirection.In)] GLEnum src)
            => ImplReadBuffer(src);

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
        public void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisample(target, samples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResumeTransformFeedback()
            => ImplResumeTransformFeedback();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage3D<T0>(target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
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
        [NativeApi(EntryPoint = "glTexStorage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTexStorage2D(target, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTexStorage3D(target, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage3D<T0>(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** varyings, [Flow(FlowDirection.In)] GLEnum bufferMode)
            => ImplTransformFeedbackVaryings(program, count, varyings, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0)
            => ImplUniform1(location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1)
            => ImplUniform2(location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2)
            => ImplUniform3(location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3)
            => ImplUniform4(location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockBinding">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding)
            => ImplUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix2x3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix2x3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix2x4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix2x4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix3x2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix3x2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix3x4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix3x4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix4x2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix4x2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix4x3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix4x3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapBuffer([Flow(FlowDirection.In)] GLEnum target)
            => ImplUnmapBuffer(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribDivisor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexAttribDivisor(index, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplVertexAttribI4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w)
            => ImplVertexAttribI4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v)
            => ImplVertexAttribI4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v)
            => ImplVertexAttribI4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v)
            => ImplVertexAttribI4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v)
            => ImplVertexAttribI4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribIPointer(index, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribIPointer<T0>(index, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
            => ImplWaitSync(sync, flags, timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQuery(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="primitiveMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode)
            => ImplBeginTransformFeedback(primitiveMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id)
            => ImplBindTransformFeedback(target, id);

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
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from buffer.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value)
            => ImplClearBuffer(buffer, drawbuffer, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="drawbuffer">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="stencil">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearBufferfi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil)
            => ImplClearBuffer(buffer, drawbuffer, depth, stencil);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexImage3D<T0>(target, level, internalformat, width, height, depth, border, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data)
            => ImplCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="imageSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from imageSize.
        /// </param>
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplCompressedTexSubImage3D<T0>(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount)
            => ImplDrawArraysInstanced(mode, first, count, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs)
            => ImplDrawBuffers(n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="bufs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs)
            => ImplDrawBuffers(n, bufs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount)
            => ImplDrawElementsInstanced(mode, count, type, indices, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged
            => ImplDrawElementsInstanced<T0>(mode, count, type, indices, instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices)
            => ImplDrawRangeElements(mode, start, end, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged
            => ImplDrawRangeElements<T0>(mode, start, end, count, type, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQuery")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQuery([Flow(FlowDirection.In)] QueryTarget target)
            => ImplEndQuery(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="condition">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glFenceSync")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags)
            => ImplFenceSync(condition, flags);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplFlushMappedBufferRange(target, offset, length);

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
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params)
            => ImplGetBufferParameter(target, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

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
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetBufferPointer<T0>(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplGetFragDataLocation(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetInteger64v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data)
            => ImplGetInteger64(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetInternalformat(target, internalformat, pname, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetInternalformat(target, internalformat, pname, count, @params);

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
        [NativeApi(EntryPoint = "glGetQueryiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQuery(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetQueryiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetStringi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public string GetString([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index)
            => ImplGetString(name, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetSynciv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetSync(sync, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GlslTypeToken* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GlslTypeToken type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetVertexAttribI(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments)
            => ImplInvalidateFramebuffer(target, numAttachments, attachments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numAttachments">
        /// To be added.
        /// </param>
        /// <param name="attachments">
        /// To be added.
        /// This parameter's element count is taken from numAttachments.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access)
            => ImplMapBufferRange(target, offset, length, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value)
            => ImplProgramParameter(program, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="src">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadBuffer([Flow(FlowDirection.In)] ReadBufferMode src)
            => ImplReadBuffer(src);

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
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="border">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexImage3D<T0>(target, level, internalformat, width, height, depth, border, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
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
        [NativeApi(EntryPoint = "glTexStorage2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplTexStorage2D(target, levels, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
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
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth)
            => ImplTexStorage3D(target, levels, internalformat, width, height, depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels)
            => ImplTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pixels">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, height, and depth.
        /// </param>
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged
            => ImplTexSubImage3D<T0>(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
            => ImplTransformFeedbackVaryings(program, count, varyings, bufferMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target)
            => ImplUnmapBuffer(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribIPointer(index, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribIPointer<T0>(index, size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveShaderProgram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program)
            => ImplActiveShaderProgram(pipeline, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] GLEnum format)
            => ImplBindImageTexture(unit, texture, level, layered, layer, access, format);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindProgramPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline)
            => ImplBindProgramPipeline(pipeline);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride)
            => ImplBindVertexBuffer(bindingindex, buffer, offset, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** strings)
            => ImplCreateShaderProgram(type, count, strings);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines)
            => ImplDeleteProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> pipelines)
            => ImplDeleteProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num_groups_x">
        /// To be added.
        /// </param>
        /// <param name="num_groups_y">
        /// To be added.
        /// </param>
        /// <param name="num_groups_z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDispatchCompute")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z)
            => ImplDispatchCompute(num_groups_x, num_groups_y, num_groups_z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect)
            => ImplDispatchComputeIndirect(indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawArraysIndirect(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawArraysIndirect<T0>(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawElementsIndirect(mode, type, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawElementsIndirect<T0>(mode, type, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param)
            => ImplFramebufferParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines)
            => ImplGenProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines)
            => ImplGenProgramPipelines(n, pipelines);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBoolean(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBoolean(target, index, data);

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
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramPipeline(pipeline, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramPipeline(pipeline, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog)
            => ImplGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog)
            => ImplGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsProgramPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline)
            => ImplIsProgramPipeline(pipeline);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="barriers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryBarrier")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MemoryBarrier([Flow(FlowDirection.In)] uint barriers)
            => ImplMemoryBarrier(barriers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="barriers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers)
            => ImplMemoryBarrierByRegion(barriers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0)
            => ImplProgramUniform1(program, location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform1(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1)
            => ImplProgramUniform2(program, location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform2(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2)
            => ImplProgramUniform3(program, location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform3(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4i")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4f")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3)
            => ImplProgramUniform4(program, location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniform4(program, location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix2x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix3x4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4x2(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplProgramUniformMatrix4x3(program, location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="maskNumber">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleMaski")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask)
            => ImplSampleMask(maskNumber, mask);

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
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="stages">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUseProgramStages")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program)
            => ImplUseProgramStages(pipeline, stages, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glValidateProgramPipeline")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline)
            => ImplValidateProgramPipeline(pipeline);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex)
            => ImplVertexAttribBinding(attribindex, bindingindex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribIFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexBindingDivisor(bindingindex, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format)
            => ImplBindImageTexture(unit, texture, level, layered, layer, access, format);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** strings)
            => ImplCreateShaderProgram(type, count, strings);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawArraysIndirect(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawArraysIndirect<T0>(mode, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect)
            => ImplDrawElementsIndirect(mode, type, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged
            => ImplDrawElementsIndirect<T0>(mode, type, indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param)
            => ImplFramebufferParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBoolean(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBoolean(target, index, data);

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
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFramebufferParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFramebufferParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="val">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val)
            => ImplGetMultisample(pname, index, val);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramPipeline(pipeline, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramPipeline(pipeline, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pipeline">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetTexLevelParameter(target, level, pname, @params);

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
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribIFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBlendBarrier")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendBarrier()
            => ImplBlendBarrier();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum mode)
            => ImplBlendEquation(buf, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha)
            => ImplBlendEquationSeparate(buf, modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFunci")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] GLEnum dst)
            => ImplBlendFunc(buf, src, dst);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="srcRGB">
        /// To be added.
        /// </param>
        /// <param name="dstRGB">
        /// To be added.
        /// </param>
        /// <param name="srcAlpha">
        /// To be added.
        /// </param>
        /// <param name="dstAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha)
            => ImplBlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorMaski")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a)
            => ImplColorMask(index, r, g, b, a);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcName">
        /// To be added.
        /// </param>
        /// <param name="srcTarget">
        /// To be added.
        /// </param>
        /// <param name="srcLevel">
        /// To be added.
        /// </param>
        /// <param name="srcX">
        /// To be added.
        /// </param>
        /// <param name="srcY">
        /// To be added.
        /// </param>
        /// <param name="srcZ">
        /// To be added.
        /// </param>
        /// <param name="dstName">
        /// To be added.
        /// </param>
        /// <param name="dstTarget">
        /// To be added.
        /// </param>
        /// <param name="dstLevel">
        /// To be added.
        /// </param>
        /// <param name="dstX">
        /// To be added.
        /// </param>
        /// <param name="dstY">
        /// To be added.
        /// </param>
        /// <param name="dstZ">
        /// To be added.
        /// </param>
        /// <param name="srcWidth">
        /// To be added.
        /// </param>
        /// <param name="srcHeight">
        /// To be added.
        /// </param>
        /// <param name="srcDepth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyImageSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth)
            => ImplCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam)
            => ImplDebugMessageCallback(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] Span<T0> userParam) where T0 : unmanaged
            => ImplDebugMessageCallback<T0>(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is computed from buf and length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] char* buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is computed from buf and length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ref char buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisablei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index)
            => ImplDisable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsBaseVertex(mode, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsBaseVertex<T0>(mode, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsInstancedBaseVertex<T0>(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawRangeElementsBaseVertex<T0>(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnablei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index)
            => ImplEnable(target, index);

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
        [NativeApi(EntryPoint = "glFramebufferTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture(target, attachment, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetGraphicsResetStatus")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public GLEnum GetGraphicsResetStatus()
            => ImplGetGraphicsResetStatus();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label)
            => ImplGetObjectLabel(identifier, name, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label)
            => ImplGetObjectLabel(identifier, name, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label)
            => ImplGetObjectPtrLabel(ptr, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label) where T0 : unmanaged
            => ImplGetObjectPtrLabel<T0>(ptr, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetPointer(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetPointer<T0>(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetTexParameterI(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabled(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinSampleShading")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MinSampleShading([Flow(FlowDirection.In)] float value)
            => ImplMinSampleShading(value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label)
            => ImplObjectLabel(identifier, name, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label)
            => ImplObjectLabel(identifier, name, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label)
            => ImplObjectPtrLabel(ptr, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label) where T0 : unmanaged
            => ImplObjectPtrLabel<T0>(ptr, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPatchParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value)
            => ImplPatchParameter(pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPopDebugGroup")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PopDebugGroup()
            => ImplPopDebugGroup();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="minX">
        /// To be added.
        /// </param>
        /// <param name="minY">
        /// To be added.
        /// </param>
        /// <param name="minZ">
        /// To be added.
        /// </param>
        /// <param name="minW">
        /// To be added.
        /// </param>
        /// <param name="maxX">
        /// To be added.
        /// </param>
        /// <param name="maxY">
        /// To be added.
        /// </param>
        /// <param name="maxZ">
        /// To be added.
        /// </param>
        /// <param name="maxW">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPrimitiveBoundingBox")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PrimitiveBoundingBox([Flow(FlowDirection.In)] float minX, [Flow(FlowDirection.In)] float minY, [Flow(FlowDirection.In)] float minZ, [Flow(FlowDirection.In)] float minW, [Flow(FlowDirection.In)] float maxX, [Flow(FlowDirection.In)] float maxY, [Flow(FlowDirection.In)] float maxZ, [Flow(FlowDirection.In)] float maxW)
            => ImplPrimitiveBoundingBox(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is computed from message and length.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] char* message)
            => ImplPushDebugGroup(source, id, length, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is computed from message and length.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ref char message)
            => ImplPushDebugGroup(source, id, length, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data)
            => ImplReadnPixels(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTexBuffer(target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTexBufferRange(target, internalformat, buffer, offset, size);

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
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplTexParameterI(target, pname, @params);

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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode)
            => ImplBlendEquation(buf, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha)
            => ImplBlendEquationSeparate(buf, modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFunci")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst)
            => ImplBlendFunc(buf, src, dst);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="srcRGB">
        /// To be added.
        /// </param>
        /// <param name="dstRGB">
        /// To be added.
        /// </param>
        /// <param name="srcAlpha">
        /// To be added.
        /// </param>
        /// <param name="dstAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha)
            => ImplBlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcName">
        /// To be added.
        /// </param>
        /// <param name="srcTarget">
        /// To be added.
        /// </param>
        /// <param name="srcLevel">
        /// To be added.
        /// </param>
        /// <param name="srcX">
        /// To be added.
        /// </param>
        /// <param name="srcY">
        /// To be added.
        /// </param>
        /// <param name="srcZ">
        /// To be added.
        /// </param>
        /// <param name="dstName">
        /// To be added.
        /// </param>
        /// <param name="dstTarget">
        /// To be added.
        /// </param>
        /// <param name="dstLevel">
        /// To be added.
        /// </param>
        /// <param name="dstX">
        /// To be added.
        /// </param>
        /// <param name="dstY">
        /// To be added.
        /// </param>
        /// <param name="dstZ">
        /// To be added.
        /// </param>
        /// <param name="srcWidth">
        /// To be added.
        /// </param>
        /// <param name="srcHeight">
        /// To be added.
        /// </param>
        /// <param name="srcDepth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyImageSubData")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth)
            => ImplCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisablei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplDisable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsBaseVertex(mode, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsBaseVertex<T0>(mode, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawElementsInstancedBaseVertex<T0>(mode, count, type, indices, instancecount, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex)
            => ImplDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is computed from count and type.
        /// </param>
        /// <param name="basevertex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
            => ImplDrawRangeElementsBaseVertex<T0>(mode, start, end, count, type, indices, basevertex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnablei")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplEnable(target, index);

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
        [NativeApi(EntryPoint = "glFramebufferTexture")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture(target, attachment, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label)
            => ImplGetObjectLabel(identifier, name, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label)
            => ImplGetObjectLabel(identifier, name, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label)
            => ImplGetObjectPtrLabel(ptr, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label) where T0 : unmanaged
            => ImplGetObjectPtrLabel<T0>(ptr, bufSize, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetPointer(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetPointer<T0>(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetTexParameterI(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledi")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabled(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label)
            => ImplObjectLabel(identifier, name, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label)
            => ImplObjectPtrLabel(ptr, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged
            => ImplObjectPtrLabel<T0>(ptr, length, label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPatchParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value)
            => ImplPatchParameter(pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message)
            => ImplPushDebugGroup(source, id, length, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data)
            => ImplReadnPixels(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixels")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTexBuffer(target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplTexBufferRange(target, internalformat, buffer, offset, size);

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
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params)
            => ImplTexParameterI(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params)
            => ImplTexParameterI(target, pname, @params);

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
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
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
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetFloat([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetInteger([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetFloat([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetInteger([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe GLEnum ClientWaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            DeleteSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe long GetInteger64([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (char**) SilkMarshal.MarshalStringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool IsSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return IsSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] GLEnum bufferMode)
        {
            // StringArrayOverloader
            var varyings = (char**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            WaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe long GetInteger64([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // StringArrayOverloader
            var varyings = (char**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            BindVertexBuffer(bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version 3.2")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GetPointervPName pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new OpenGLESLibraryNameContainer();

        public GL(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

