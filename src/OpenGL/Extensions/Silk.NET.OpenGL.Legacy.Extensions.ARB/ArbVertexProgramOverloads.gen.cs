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
    public static class ArbVertexProgramOverloads
    {
        public static unsafe void DeleteProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void DeleteProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void GenProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GenProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Program> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameter(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameter(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramString(target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramString(target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramString(target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetProgramString(target, pname, out @string.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameter4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameter4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramString(target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void ProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramString(target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void ProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramString(target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void ProgramString<T0>(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ProgramString(target, format, len, in @string.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

    }
}

