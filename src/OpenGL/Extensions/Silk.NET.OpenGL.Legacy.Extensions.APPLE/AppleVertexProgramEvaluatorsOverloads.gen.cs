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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    public static class AppleVertexProgramEvaluatorsOverloads
    {
        public static unsafe void MapVertexAttrib1(this AppleVertexProgramEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib1(index, size, u1, u2, stride, order, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib1(this AppleVertexProgramEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib1(index, size, u1, u2, stride, order, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib2(this AppleVertexProgramEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib2(this AppleVertexProgramEvaluators thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, in points.GetPinnableReference());
        }

    }
}

