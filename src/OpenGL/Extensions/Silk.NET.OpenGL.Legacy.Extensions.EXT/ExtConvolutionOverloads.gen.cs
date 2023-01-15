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
    public static class ExtConvolutionOverloads
    {
        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter1D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter1D(target, internalformat, width, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ConvolutionFilter2D(target, internalformat, width, height, format, type, in image.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetConvolutionFilter(target, format, type, out image.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameter(this ExtConvolution thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, row, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, span);
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), column, out span.GetPinnableReference());
        }

        public static unsafe void GetSeparableFilter<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), span);
        }

        public static unsafe void GetSeparableFilter<T0, T1, T2>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetSeparableFilter(target, format, type, out row.GetPinnableReference(), out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T0> column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, row, in column.GetPinnableReference());
        }

        public static unsafe void SeparableFilter2D<T0>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), column);
        }

        public static unsafe void SeparableFilter2D<T0, T1>(this ExtConvolution thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ReadOnlySpan<T0> row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ReadOnlySpan<T1> column) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.SeparableFilter2D(target, internalformat, width, height, format, type, in row.GetPinnableReference(), in column.GetPinnableReference());
        }

    }
}

