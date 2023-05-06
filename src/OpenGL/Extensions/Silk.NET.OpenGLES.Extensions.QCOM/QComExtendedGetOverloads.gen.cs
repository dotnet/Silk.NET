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
        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(buffers, maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, numBuffers);
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(buffers, maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, numBuffers);
        }

        public static unsafe void ExtGetBuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numBuffers)
        {
            // SpanOverloader
            thisApi.ExtGetBuffers(out buffers.GetPinnableReference(), maxBuffers, out numBuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(framebuffers, maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, numFramebuffers);
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(framebuffers, maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, numFramebuffers);
        }

        public static unsafe void ExtGetFramebuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numFramebuffers)
        {
            // SpanOverloader
            thisApi.ExtGetFramebuffers(out framebuffers.GetPinnableReference(), maxFramebuffers, out numFramebuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, numRenderbuffers);
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, numRenderbuffers);
        }

        public static unsafe void ExtGetRenderbuffers(this QComExtendedGet thisApi, [Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numRenderbuffers)
        {
            // SpanOverloader
            thisApi.ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), maxRenderbuffers, out numRenderbuffers.GetPinnableReference());
        }

        public static unsafe void ExtGetTexLevelParameter(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.ExtGetTexLevelParameter(texture, face, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTexSubImage<T0>(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out texels.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(textures, maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, numTextures);
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(textures, maxTextures, out numTextures.GetPinnableReference());
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, numTextures);
        }

        public static unsafe void ExtGetTextures(this QComExtendedGet thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numTextures)
        {
            // SpanOverloader
            thisApi.ExtGetTextures(out textures.GetPinnableReference(), maxTextures, out numTextures.GetPinnableReference());
        }

    }
}

