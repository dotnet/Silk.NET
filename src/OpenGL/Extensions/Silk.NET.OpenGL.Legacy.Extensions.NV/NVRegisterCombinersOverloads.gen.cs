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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVRegisterCombinersOverloads
    {
        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.CombinerParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerInputParameter(stage, portion, variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerOutputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerOutputParameter(stage, portion, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFinalCombinerInputParameter(this NVRegisterCombiners thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFinalCombinerInputParameter(variable, pname, out @params.GetPinnableReference());
        }

    }
}

