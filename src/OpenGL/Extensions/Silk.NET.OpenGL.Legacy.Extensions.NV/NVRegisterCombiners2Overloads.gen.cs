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
    public static class NVRegisterCombiners2Overloads
    {
        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void CombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.CombinerStageParameter(stage, pname, in @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetCombinerStageParameter(this NVRegisterCombiners2 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetCombinerStageParameter(stage, pname, out @params.GetPinnableReference());
        }

    }
}

