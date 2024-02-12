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

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    public static class MesaSamplerObjectsOverloads
    {
        public static unsafe void DeleteSamplers(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // SpanOverloader
            thisApi.DeleteSamplers(count, in samplers.GetPinnableReference());
        }

        public static unsafe void DeleteSamplers(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.DeleteSamplers(count, in samplers.GetPinnableReference());
        }

        public static unsafe void GenSamplers(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> samplers)
        {
            // SpanOverloader
            thisApi.GenSamplers(count, out samplers.GetPinnableReference());
        }

        public static unsafe void GenSamplers(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> samplers)
        {
            // SpanOverloader
            thisApi.GenSamplers(count, out samplers.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameter(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameter(this MesaSamplerObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> param)
        {
            // SpanOverloader
            thisApi.SamplerParameter(sampler, pname, in param.GetPinnableReference());
        }

    }
}

