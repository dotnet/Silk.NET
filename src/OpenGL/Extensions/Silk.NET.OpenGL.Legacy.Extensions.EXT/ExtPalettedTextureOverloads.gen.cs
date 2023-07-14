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
        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalFormat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out data.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ExtPalettedTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

