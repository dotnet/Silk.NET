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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixPolynomialFfdOverloads
    {
        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] double w1, [Flow(FlowDirection.In)] double w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(FlowDirection.In)] SGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(FlowDirection.In)] FfdTargetSGIX target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] float w1, [Flow(FlowDirection.In)] float w2, [Flow(FlowDirection.In)] int wstride, [Flow(FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

    }
}

