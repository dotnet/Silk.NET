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
    public static class NVRegisterCombinersOverloads
    {
        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

    }
}

