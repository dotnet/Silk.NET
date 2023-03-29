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
    public static class ArbImagingOverloads
    {
        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.ColorTable(target, internalformat, width, format, type, tableSpp);
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ColorTableParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, imageSpp);
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetColorTable(target, format, type, tableSpp);
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetColorTableParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetColorTableParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetConvolutionFilter(target, format, type, imageSpp);
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetSeparableFilter(target, format, type, rowSpp, columnSpp, spanSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] Span<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] Span<T1> column) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
                thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, rowSpp, columnSpp);
        }

    }
}

