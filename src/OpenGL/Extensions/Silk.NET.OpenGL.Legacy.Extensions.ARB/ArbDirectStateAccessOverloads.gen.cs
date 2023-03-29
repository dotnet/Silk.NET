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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbDirectStateAccessOverloads
    {
        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferData(buffer, internalformat, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedBufferSubData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, dataSpp);
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void ClearNamedFramebuffer(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ClearNamedFramebuffer(framebuffer, buffer, drawbuffer, in value.GetPinnableReference());
        }

        public static unsafe void CompressedTextureSubImage1D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, dataSpp);
        }

        public static unsafe void CompressedTextureSubImage2D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, dataSpp);
        }

        public static unsafe void CompressedTextureSubImage3D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, dataSpp);
        }

        public static unsafe void CreateBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
        {
            // SpanOverloader
            thisApi.CreateBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void CreateBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.CreateBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void CreateFramebuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers)
        {
            // SpanOverloader
            thisApi.CreateFramebuffers(n, out framebuffers.GetPinnableReference());
        }

        public static unsafe void CreateFramebuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers)
        {
            // SpanOverloader
            thisApi.CreateFramebuffers(n, out framebuffers.GetPinnableReference());
        }

        public static unsafe void CreateProgramPipelines(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines)
        {
            // SpanOverloader
            thisApi.CreateProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void CreateProgramPipelines(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<ProgramPipeline> pipelines)
        {
            // SpanOverloader
            thisApi.CreateProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void CreateQueries(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.CreateQueries(target, n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateQueries(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Query> ids)
        {
            // SpanOverloader
            thisApi.CreateQueries(target, n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateQueries(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.CreateQueries(target, n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateQueries(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Query> ids)
        {
            // SpanOverloader
            thisApi.CreateQueries(target, n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateRenderbuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // SpanOverloader
            thisApi.CreateRenderbuffers(n, out renderbuffers.GetPinnableReference());
        }

        public static unsafe void CreateRenderbuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // SpanOverloader
            thisApi.CreateRenderbuffers(n, out renderbuffers.GetPinnableReference());
        }

        public static unsafe void CreateSamplers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers)
        {
            // SpanOverloader
            thisApi.CreateSamplers(n, out samplers.GetPinnableReference());
        }

        public static unsafe void CreateSamplers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.CreateSamplers(n, out samplers.GetPinnableReference());
        }

        public static unsafe void CreateTextures(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
        {
            // SpanOverloader
            thisApi.CreateTextures(target, n, out textures.GetPinnableReference());
        }

        public static unsafe void CreateTextures(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Texture> textures)
        {
            // SpanOverloader
            thisApi.CreateTextures(target, n, out textures.GetPinnableReference());
        }

        public static unsafe void CreateTextures(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures)
        {
            // SpanOverloader
            thisApi.CreateTextures(target, n, out textures.GetPinnableReference());
        }

        public static unsafe void CreateTextures(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Texture> textures)
        {
            // SpanOverloader
            thisApi.CreateTextures(target, n, out textures.GetPinnableReference());
        }

        public static unsafe void CreateTransformFeedbacks(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.CreateTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateTransformFeedbacks(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.CreateTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void CreateVertexArrays(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
        {
            // SpanOverloader
            thisApi.CreateVertexArrays(n, out arrays.GetPinnableReference());
        }

        public static unsafe void CreateVertexArrays(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // SpanOverloader
            thisApi.CreateVertexArrays(n, out arrays.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferAttachmentParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetNamedRenderbufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedRenderbufferParameter(renderbuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedRenderbufferParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedRenderbufferParameter(renderbuffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureImage<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.GetTextureImage(texture, level, format, type, bufSize, pixelsSpp);
        }

        public static unsafe void GetTextureImage<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.GetTextureImage(texture, level, format, type, bufSize, pixelsSpp);
        }

        public static unsafe void GetTextureImage<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.GetTextureImage(texture, level, format, type, bufSize, pixelsSpp);
        }

        public static unsafe void GetTextureLevelParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureLevelParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureLevelParameter(texture, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameter(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTextureParameterI(texture, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedback(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedback(xfb, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedback(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedback(xfb, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedback(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedback(xfb, pname, index, out param.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedback(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedback(xfb, pname, index, out param.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbacki64(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbacki64(xfb, pname, index, out param.GetPinnableReference());
        }

        public static unsafe void GetTransformFeedbacki64(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param)
        {
            // SpanOverloader
            thisApi.GetTransformFeedbacki64(xfb, pname, index, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArray(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArray(vaobj, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArray(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArray(vaobj, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayIndexed(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayIndexed(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayIndexed(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayIndexed(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayIndexed64(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayIndexed64(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void GetVertexArrayIndexed64(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param)
        {
            // SpanOverloader
            thisApi.GetVertexArrayIndexed64(vaobj, index, pname, out param.GetPinnableReference());
        }

        public static unsafe void InvalidateNamedFramebufferData(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateNamedFramebufferData(framebuffer, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateNamedFramebufferData(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<FramebufferAttachment> attachments)
        {
            // SpanOverloader
            thisApi.InvalidateNamedFramebufferData(framebuffer, numAttachments, in attachments.GetPinnableReference());
        }

        public static unsafe void InvalidateNamedFramebufferSubData(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateNamedFramebufferSubData(framebuffer, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void InvalidateNamedFramebufferSubData(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] ReadOnlySpan<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
        {
            // SpanOverloader
            thisApi.InvalidateNamedFramebufferSubData(framebuffer, numAttachments, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public static unsafe void NamedBufferData<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.NamedBufferData(buffer, size, dataSpp, usage);
        }

        public static unsafe void NamedBufferStorage<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.NamedBufferStorage(buffer, size, dataSpp, flags);
        }

        public static unsafe void NamedFramebufferDrawBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> bufs)
        {
            // SpanOverloader
            thisApi.NamedFramebufferDrawBuffers(framebuffer, n, in bufs.GetPinnableReference());
        }

        public static unsafe void NamedFramebufferDrawBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ColorBuffer> bufs)
        {
            // SpanOverloader
            thisApi.NamedFramebufferDrawBuffers(framebuffer, n, in bufs.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, pname, in param.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, pname, in param.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, pname, in param.GetPinnableReference());
        }

        public static unsafe void TextureParameter(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.TextureParameter(texture, pname, in param.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureParameterI(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TextureParameterI(texture, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TextureSubImage1D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage1D(texture, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage1D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage1D(texture, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage1D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage1D(texture, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage2D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage2D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage2D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage3D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage3D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TextureSubImage3D<T0>(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), offsets, strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), offsets, strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public static unsafe void VertexArrayVertexBuffers(this ArbDirectStateAccess thisApi, [Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // SpanOverloader
            thisApi.VertexArrayVertexBuffers(vaobj, first, count, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

    }
}

