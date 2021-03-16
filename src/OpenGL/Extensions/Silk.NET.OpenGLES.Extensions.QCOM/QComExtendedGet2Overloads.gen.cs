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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    public static class QComExtendedGet2Overloads
    {
        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] uint* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(programs, maxPrograms, out numPrograms.GetPinnableReference());
        }

        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(out programs.GetPinnableReference(), maxPrograms, numPrograms);
        }

        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(out programs.GetPinnableReference(), maxPrograms, out numPrograms.GetPinnableReference());
        }

        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Program* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(programs, maxPrograms, out numPrograms.GetPinnableReference());
        }

        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<Program> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(out programs.GetPinnableReference(), maxPrograms, numPrograms);
        }

        public static unsafe void ExtGetProgram(this QComExtendedGet2 thisApi, [Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<Program> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numPrograms)
        {
            // SpanOverloader
            thisApi.ExtGetProgram(out programs.GetPinnableReference(), maxPrograms, out numPrograms.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, source, out length.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] Span<byte> source, [Flow(FlowDirection.Out)] int* length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, out source.GetPinnableReference(), length);
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] Span<byte> source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, out source.GetPinnableReference(), out length.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, source, out length.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, source, out length.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] Span<byte> source, [Flow(FlowDirection.Out)] int* length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, out source.GetPinnableReference(), length);
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] Span<byte> source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, out source.GetPinnableReference(), out length.GetPinnableReference());
        }

        public static unsafe void ExtGetProgramBinarySource(this QComExtendedGet2 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] Span<int> length)
        {
            // SpanOverloader
            thisApi.ExtGetProgramBinarySource(program, shadertype, source, out length.GetPinnableReference());
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] uint* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(shaders, maxShaders, out numShaders.GetPinnableReference());
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(out shaders.GetPinnableReference(), maxShaders, numShaders);
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(out shaders.GetPinnableReference(), maxShaders, out numShaders.GetPinnableReference());
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Shader* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(shaders, maxShaders, out numShaders.GetPinnableReference());
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<Shader> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(out shaders.GetPinnableReference(), maxShaders, numShaders);
        }

        public static unsafe void ExtGetShaders(this QComExtendedGet2 thisApi, [Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<Shader> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> numShaders)
        {
            // SpanOverloader
            thisApi.ExtGetShaders(out shaders.GetPinnableReference(), maxShaders, out numShaders.GetPinnableReference());
        }

    }
}

