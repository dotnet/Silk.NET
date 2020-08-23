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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    public static class SgisPixelTextureOverloads
    {
        public static unsafe void GetPixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTexGenParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetPixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTexGenParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetPixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTexGenParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetPixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetPixelTexGenParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void PixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTexGenParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PixelTexGenParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTexGenParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void PixelTexGenParameter(this SgisPixelTexture thisApi, [Flow(FlowDirection.In)] PixelTexGenParameterNameSGIS pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.PixelTexGenParameter(pname, in @params.GetPinnableReference());
        }

    }
}

