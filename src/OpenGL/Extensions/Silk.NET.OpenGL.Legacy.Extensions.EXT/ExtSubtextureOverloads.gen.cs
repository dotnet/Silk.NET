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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtSubtextureOverloads
    {
        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage1D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage1D(target, level, xoffset, width, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage2D<T0>(this ExtSubtexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixelsSpp);
        }

    }
}

