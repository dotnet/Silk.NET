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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    public static class SgiColorTableOverloads
    {
        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this SgiColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

