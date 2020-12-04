// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe void MapVertexAttrib1(this AppleVertexProgramEvaluators thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib1(index, size, u1, u2, stride, order, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib1(this AppleVertexProgramEvaluators thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib1(index, size, u1, u2, stride, order, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib2(this AppleVertexProgramEvaluators thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, in points.GetPinnableReference());
        }

        public static unsafe void MapVertexAttrib2(this AppleVertexProgramEvaluators thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.MapVertexAttrib2(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, in points.GetPinnableReference());
        }

    }
}

