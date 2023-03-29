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
    public static class ExtTexture3DOverloads
    {
        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] Span<T0> pixels) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pixelsSpp = pixels)
                thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixelsSpp);
        }

    }
}

