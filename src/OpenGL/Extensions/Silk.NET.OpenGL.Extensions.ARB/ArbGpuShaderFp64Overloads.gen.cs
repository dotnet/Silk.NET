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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbGpuShaderFp64Overloads
    {
        public static unsafe void GetUniform(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2x3(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2x4(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x2(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x4(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x2(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x3(this ArbGpuShaderFp64 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x3(location, count, transpose, in value.GetPinnableReference());
        }

    }
}

