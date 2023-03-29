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
    public static class ArbFragmentProgramOverloads
    {
        public static unsafe void DeleteProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void DeleteProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void GenProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GenProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Program> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.GetProgramString(target, pname, @stringSpp);
        }

        public static unsafe void GetProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.GetProgramString(target, pname, @stringSpp);
        }

        public static unsafe void GetProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.GetProgramString(target, pname, @stringSpp);
        }

        public static unsafe void ProgramEnvParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.ProgramString(target, format, len, @stringSpp);
        }

        public static unsafe void ProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.ProgramString(target, format, len, @stringSpp);
        }

        public static unsafe void ProgramString<T0>(this ArbFragmentProgram thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : struct
        {
            // SpanOverloader
            fixed (void* @stringSpp = @string)
                thisApi.ProgramString(target, format, len, @stringSpp);
        }

    }
}

