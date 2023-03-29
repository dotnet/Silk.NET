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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    public static class SgisTexture4DOverloads
    {
        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] SGIS internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage4D(target, level, internalformat, width, height, depth, size4d, border, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] SGIS format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage4D<T0>(this SgisTexture4D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int woffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint size4d, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage4D(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixelsSpp);
        }

    }
}

