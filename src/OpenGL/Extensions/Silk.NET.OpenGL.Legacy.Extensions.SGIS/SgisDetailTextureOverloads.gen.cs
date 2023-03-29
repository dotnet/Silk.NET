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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    public static class SgisDetailTextureOverloads
    {
        public static unsafe void DetailTexFunc(this SgisDetailTexture thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DetailTexFunc(target, n, in points.GetPinnableReference());
        }

        public static unsafe void DetailTexFunc(this SgisDetailTexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.DetailTexFunc(target, n, in points.GetPinnableReference());
        }

        public static unsafe void GetDetailTexFunc(this SgisDetailTexture thisApi, [Flow(FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> points)
        {
            // SpanOverloader
            thisApi.GetDetailTexFunc(target, out points.GetPinnableReference());
        }

        public static unsafe void GetDetailTexFunc(this SgisDetailTexture thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> points)
        {
            // SpanOverloader
            thisApi.GetDetailTexFunc(target, out points.GetPinnableReference());
        }

    }
}

