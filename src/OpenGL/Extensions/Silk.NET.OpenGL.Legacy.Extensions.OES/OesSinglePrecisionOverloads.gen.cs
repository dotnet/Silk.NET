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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    public static class OesSinglePrecisionOverloads
    {
        public static unsafe void ClipPlane(this OesSinglePrecision thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> equation)
        {
            // SpanOverloader
            thisApi.ClipPlane(plane, in equation.GetPinnableReference());
        }

        public static unsafe void ClipPlane(this OesSinglePrecision thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> equation)
        {
            // SpanOverloader
            thisApi.ClipPlane(plane, in equation.GetPinnableReference());
        }

        public static unsafe void GetClipPlane(this OesSinglePrecision thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlane(plane, out equation.GetPinnableReference());
        }

        public static unsafe void GetClipPlane(this OesSinglePrecision thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlane(plane, out equation.GetPinnableReference());
        }

    }
}

