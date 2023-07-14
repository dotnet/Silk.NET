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
        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapAttribParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapAttribParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, out points.GetPinnableReference());
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTypeNV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, out points.GetPinnableReference());
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, out points.GetPinnableReference());
        }

        public static unsafe void GetMapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTypeNV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetMapControlPoints(target, index, type, ustride, vstride, packed, out points.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetMapParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, in points.GetPinnableReference());
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTypeNV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, in points.GetPinnableReference());
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, in points.GetPinnableReference());
        }

        public static unsafe void MapControlPoints<T0>(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTypeNV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> points) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, in points.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void MapParameter(this NVEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EvalTargetNV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.MapParameter(target, pname, in @params.GetPinnableReference());
        }

    }
}

