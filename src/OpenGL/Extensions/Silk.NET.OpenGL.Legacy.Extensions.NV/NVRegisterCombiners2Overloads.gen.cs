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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVRegisterCombiners2Overloads
    {
        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

    }
}

