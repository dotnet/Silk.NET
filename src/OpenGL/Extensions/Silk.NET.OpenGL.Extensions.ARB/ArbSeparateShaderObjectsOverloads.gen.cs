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
    public static class ArbSeparateShaderObjectsOverloads
    {
        public static unsafe void DeleteProgramPipelines(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pipelines)
        {
            // SpanOverloader
            thisApi.DeleteProgramPipelines(n, in pipelines.GetPinnableReference());
        }

        public static unsafe void DeleteProgramPipelines(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramPipeline> pipelines)
        {
            // SpanOverloader
            thisApi.DeleteProgramPipelines(n, in pipelines.GetPinnableReference());
        }

        public static unsafe void GenProgramPipelines(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines)
        {
            // SpanOverloader
            thisApi.GenProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void GenProgramPipelines(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<ProgramPipeline> pipelines)
        {
            // SpanOverloader
            thisApi.GenProgramPipelines(n, out pipelines.GetPinnableReference());
        }

        public static unsafe void GetProgramPipeline(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramPipeline(pipeline, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramPipeline(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramPipeline(pipeline, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetProgramPipelineInfoLog(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetProgramPipelineInfoLog(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetProgramPipelineInfoLog(pipeline, bufSize, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform1(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform1(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform2(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform3(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniform4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.ProgramUniform4(program, location, count, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix2x4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix2x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix3x4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix3x4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x2(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x2(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void ProgramUniformMatrix4x3(this ArbSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // SpanOverloader
            thisApi.ProgramUniformMatrix4x3(program, location, count, transpose, in value.GetPinnableReference());
        }

    }
}

