// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    public static class OesSinglePrecisionOverloads
    {
        public static unsafe void ClipPlane(this OesSinglePrecision thisApi, [Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> equation)
        {
            // SpanOverloader
            thisApi.ClipPlane(plane, in equation.GetPinnableReference());
        }

        public static unsafe void ClipPlane(this OesSinglePrecision thisApi, [Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> equation)
        {
            // SpanOverloader
            thisApi.ClipPlane(plane, in equation.GetPinnableReference());
        }

        public static unsafe void GetClipPlane(this OesSinglePrecision thisApi, [Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlane(plane, out equation.GetPinnableReference());
        }

        public static unsafe void GetClipPlane(this OesSinglePrecision thisApi, [Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlane(plane, out equation.GetPinnableReference());
        }

    }
}

