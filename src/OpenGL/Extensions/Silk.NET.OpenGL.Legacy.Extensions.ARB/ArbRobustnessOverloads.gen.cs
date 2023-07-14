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
    public static class ArbRobustnessOverloads
    {
        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnColorTable(target, format, type, bufSize, out table.GetPinnableReference());
        }

        public static unsafe void GetnCompressedTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnCompressedTexImage(target, lod, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnCompressedTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnCompressedTexImage(target, lod, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnConvolutionFilter(target, format, type, bufSize, out image.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnHistogram(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnMinmax(target, reset, format, type, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPolygonStipple(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> pattern)
        {
            // SpanOverloader
            thisApi.GetnPolygonStipple(bufSize, out pattern.GetPinnableReference());
        }

        public static unsafe void GetnPolygonStipple(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> pattern)
        {
            // SpanOverloader
            thisApi.GetnPolygonStipple(bufSize, out pattern.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, column, out span.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), span);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnSeparableFilter(target, format, type, rowBufSize, out row.GetPinnableReference(), columnBufSize, out column.GetPinnableReference(), out span.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetnTexImage(target, level, format, type, bufSize, out img.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, out data.GetPinnableReference());
        }

    }
}

