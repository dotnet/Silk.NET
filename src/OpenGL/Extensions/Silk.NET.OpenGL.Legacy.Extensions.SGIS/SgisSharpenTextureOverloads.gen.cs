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
    public static class SgisSharpenTextureOverloads
    {
        public static unsafe void GetSharpenTexFunc(this SgisSharpenTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> points)
        {
            // SpanOverloader
            thisApi.GetSharpenTexFunc(target, out points.GetPinnableReference());
        }

        public static unsafe void GetSharpenTexFunc(this SgisSharpenTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> points)
        {
            // SpanOverloader
            thisApi.GetSharpenTexFunc(target, out points.GetPinnableReference());
        }

        public static unsafe void SharpenTexFunc(this SgisSharpenTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.SharpenTexFunc(target, n, in points.GetPinnableReference());
        }

        public static unsafe void SharpenTexFunc(this SgisSharpenTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.SharpenTexFunc(target, n, in points.GetPinnableReference());
        }

    }
}

