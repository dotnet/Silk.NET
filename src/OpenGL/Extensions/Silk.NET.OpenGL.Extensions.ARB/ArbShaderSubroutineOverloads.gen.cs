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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbShaderSubroutineOverloads
    {
        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe uint GetSubroutineIndex(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineIndex(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe uint GetSubroutineIndex(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineIndex(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe int GetSubroutineUniformLocation(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineUniformLocation(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe int GetSubroutineUniformLocation(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineUniformLocation(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe void GetUniformSubroutine(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniformSubroutine(shadertype, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniformSubroutine(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniformSubroutine(shadertype, location, out @params.GetPinnableReference());
        }

        public static unsafe void UniformSubroutines(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // SpanOverloader
            thisApi.UniformSubroutines(shadertype, count, in indices.GetPinnableReference());
        }

        public static unsafe void UniformSubroutines(this ArbShaderSubroutine thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // SpanOverloader
            thisApi.UniformSubroutines(shadertype, count, in indices.GetPinnableReference());
        }

    }
}

