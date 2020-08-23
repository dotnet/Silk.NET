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

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    public static class HPImageTransformOverloads
    {
        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetImageTransformParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ImageTransformParameter(this HPImageTransform thisApi, [Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ImageTransformParameter(target, pname, in @params.GetPinnableReference());
        }

    }
}

