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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbShaderSubroutineOverloads
    {
        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniform(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniform(program, shadertype, index, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveSubroutineUniformName(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveSubroutineUniformName(program, shadertype, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe void GetProgramStage(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetProgramStage(program, shadertype, pname, out values.GetPinnableReference());
        }

        public static unsafe uint GetSubroutineIndex(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineIndex(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe uint GetSubroutineIndex(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineIndex(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe int GetSubroutineUniformLocation(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineUniformLocation(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe int GetSubroutineUniformLocation(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetSubroutineUniformLocation(program, shadertype, in name.GetPinnableReference());
        }

        public static unsafe void GetUniformSubroutine(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniformSubroutine(shadertype, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniformSubroutine(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniformSubroutine(shadertype, location, out @params.GetPinnableReference());
        }

        public static unsafe void UniformSubroutines(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // SpanOverloader
            thisApi.UniformSubroutines(shadertype, count, in indices.GetPinnableReference());
        }

        public static unsafe void UniformSubroutines(this ArbShaderSubroutine thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // SpanOverloader
            thisApi.UniformSubroutines(shadertype, count, in indices.GetPinnableReference());
        }

    }
}

