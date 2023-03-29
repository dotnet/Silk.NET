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
    public static class NVShaderBufferLoadOverloads
    {
        public static unsafe void GetBufferParameter(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetInteger(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(FlowDirection.Out)] Span<ulong> result)
        {
            // SpanOverloader
            thisApi.GetInteger(value, out result.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedBufferParameter(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetNamedBufferParameter(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramUniform(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform(this NVShaderBufferLoad thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.Uniform(location, count, in value.GetPinnableReference());
        }

    }
}

