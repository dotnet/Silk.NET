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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtPixelTransformOverloads
    {
        public static unsafe void GetPixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetPixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTransformParameter(this ExtPixelTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTransformParameter(target, pname, in @params.GetPinnableReference());
        }

    }
}

