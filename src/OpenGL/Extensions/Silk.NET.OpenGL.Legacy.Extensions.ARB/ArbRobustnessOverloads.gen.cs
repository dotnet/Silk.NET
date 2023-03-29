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
        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnColorTable<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : struct
        {
            // SpanOverloader
            fixed (void* tableSpp = table)
                thisApi.GetnColorTable(target, format, type, bufSize, tableSpp);
        }

        public static unsafe void GetnCompressedTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnCompressedTexImage(target, lod, bufSize, imgSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnConvolutionFilter<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imageSpp = image)
                thisApi.GetnConvolutionFilter(target, format, type, bufSize, imageSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnHistogram<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnHistogram(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetnMap(target, query, bufSize, out v.GetPinnableReference());
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnMinmax<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetnMinmax(target, reset, format, type, bufSize, valuesSpp);
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPixelMap(this ArbRobustness thisApi, [Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
        {
            // SpanOverloader
            thisApi.GetnPixelMap(map, bufSize, out values.GetPinnableReference());
        }

        public static unsafe void GetnPolygonStipple(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> pattern)
        {
            // SpanOverloader
            thisApi.GetnPolygonStipple(bufSize, out pattern.GetPinnableReference());
        }

        public static unsafe void GetnPolygonStipple(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> pattern)
        {
            // SpanOverloader
            thisApi.GetnPolygonStipple(bufSize, out pattern.GetPinnableReference());
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnSeparableFilter<T0, T1, T2>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T2> span) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* rowSpp = row)
            fixed (void* columnSpp = column)
            fixed (void* spanSpp = span)
                thisApi.GetnSeparableFilter(target, format, type, rowBufSize, rowSpp, columnBufSize, columnSpp, spanSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnTexImage<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : struct
        {
            // SpanOverloader
            fixed (void* imgSpp = img)
                thisApi.GetnTexImage(target, level, format, type, bufSize, imgSpp);
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void GetnUniform(this ArbRobustness thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetnUniform(program, location, bufSize, out @params.GetPinnableReference());
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, dataSpp);
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, dataSpp);
        }

        public static unsafe void ReadnPixels<T0>(this ArbRobustness thisApi, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ReadnPixels(x, y, width, height, format, type, bufSize, dataSpp);
        }

    }
}

