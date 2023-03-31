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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    public static class QComExtendedGetOverloads
    {
        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] uint* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(buffers, maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, numBuffers);
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Buffer* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(buffers, maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<Buffer> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, numBuffers);
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<Buffer> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] uint* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(framebuffers, maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, numFramebuffers);
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Framebuffer* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(framebuffers, maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, numFramebuffers);
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] uint* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, numRenderbuffers);
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, numRenderbuffers);
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetTexLevelParameter(this QComExtendedGet thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.ExtGetTexLevelParameter(texture, face, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] uint* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(textures, maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] Span<uint> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, numTextures);
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] Span<uint> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] Texture* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(textures, maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] Span<Texture> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, numTextures);
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(FlowDirection.Out)] Span<Texture> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, out numTextures.GetPinnableReference());
        }

    }
}

