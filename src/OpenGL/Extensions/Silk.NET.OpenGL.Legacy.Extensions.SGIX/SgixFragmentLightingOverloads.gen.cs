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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixFragmentLightingOverloads
    {
        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLight(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLightModel(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLightModel(pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLightModel(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentLightModel(pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLightModel(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLightModel(pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentLightModel(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentLightModel(pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void FragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.FragmentMaterial(face, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentLight(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentLight(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFragmentMaterial(this SgixFragmentLighting thisApi, [Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFragmentMaterial(face, pname, out @params.GetPinnableReference());
        }

    }
}

