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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVEvaluatorsOverloads
    {
        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, pointsSpp);
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, pointsSpp);
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, pointsSpp);
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, pointsSpp);
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, pointsSpp);
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] Span<T0> points) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointsSpp = points)
                thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, pointsSpp);
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

    }
}

