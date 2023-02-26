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
        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorSubTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorSubTable(target, start, count, format, type, in data.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
        }

        public static unsafe void ColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ColorTable(target, internalformat, width, format, type, in table.GetPinnableReference());
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

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
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

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
        }

        public static unsafe void GetColorTable<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetColorTable(target, format, type, out table.GetPinnableReference());
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

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
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

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetHistogram<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetHistogram(target, reset, format, type, out values.GetPinnableReference());
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

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMinmax(target, reset, format, type, out values.GetPinnableReference());
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

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ArbImaging thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

    }
}

