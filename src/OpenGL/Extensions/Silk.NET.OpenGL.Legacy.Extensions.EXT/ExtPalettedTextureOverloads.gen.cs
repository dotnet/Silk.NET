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
    public static class ExtPalettedTextureOverloads
    {
        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalFormat, width, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetColorTable(target, format, type, dataSpp);
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

