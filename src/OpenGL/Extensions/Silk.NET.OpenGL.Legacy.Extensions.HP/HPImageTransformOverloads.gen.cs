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

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    public static class HPImageTransformOverloads
    {
        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformTargetHP target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

    }
}

