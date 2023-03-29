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
    public static class ExtHistogramOverloads
    {
        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogram<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetHistogram(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmax<T0>(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : struct
        {
            // SpanOverloader
            fixed (void* valuesSpp = values)
                thisApi.GetMinmax(target, reset, format, type, valuesSpp);
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMinmaxParameter(this ExtHistogram thisApi, [Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMinmaxParameter(target, pname, out @params.GetPinnableReference());
        }

    }
}

