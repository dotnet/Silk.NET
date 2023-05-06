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
        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

        public static unsafe void DeformationMap3(this SgixPolynomialFfd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FfdTargetSGIX target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int wstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int worder, [Count(Computed = "target, ustride, uorder, vstride, vorder, wstride, worder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DeformationMap3(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, in points.GetPinnableReference());
        }

    }
}

