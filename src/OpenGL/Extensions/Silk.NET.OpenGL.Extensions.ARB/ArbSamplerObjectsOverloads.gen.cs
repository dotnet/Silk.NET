// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbSamplerObjectsOverloads
    {
        public static unsafe void DeleteSamplers(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // SpanOverloader
            thisApi.DeleteSamplers(count, in samplers.GetPinnableReference());
        }

        public static unsafe void GenSamplers(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers)
        {
            // SpanOverloader
            thisApi.GenSamplers(count, out samplers.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this ArbSamplerObjects thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

    }
}

