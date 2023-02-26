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
    public static class NVVertexProgramOverloads
    {
        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, programs, out residences.GetPinnableReference());
        }

        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, in programs.GetPinnableReference(), residences);
        }

        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, programs, out residences.GetPinnableReference());
        }

        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, in programs.GetPinnableReference(), residences);
        }

        public static unsafe bool AreProgramsResident(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // SpanOverloader
            return thisApi.AreProgramsResident(n, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public static unsafe void DeleteProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void DeleteProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // SpanOverloader
            thisApi.DeleteProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void ExecuteProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ExecuteProgram(target, id, in @params.GetPinnableReference());
        }

        public static unsafe void ExecuteProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ExecuteProgram(target, id, in @params.GetPinnableReference());
        }

        public static unsafe void GenProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GenProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Program> programs)
        {
            // SpanOverloader
            thisApi.GenProgram(n, out programs.GetPinnableReference());
        }

        public static unsafe void GetProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgram(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramParameter(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramParameter(target, index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramString(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] Span<byte> program)
        {
            // SpanOverloader
            thisApi.GetProgramString(id, pname, out program.GetPinnableReference());
        }

        public static unsafe void GetProgramString(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] Span<byte> program)
        {
            // SpanOverloader
            thisApi.GetProgramString(id, pname, out program.GetPinnableReference());
        }

        public static unsafe void GetTrackMatrix(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTrackMatrix(target, address, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTrackMatrix(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTrackMatrix(target, address, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTrackMatrix(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTrackMatrix(target, address, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTrackMatrix(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTrackMatrix(target, address, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void LoadProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<byte> program)
        {
            // SpanOverloader
            thisApi.LoadProgram(target, id, len, in program.GetPinnableReference());
        }

        public static unsafe void LoadProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<byte> program)
        {
            // SpanOverloader
            thisApi.LoadProgram(target, id, len, in program.GetPinnableReference());
        }

        public static unsafe void ProgramParameter4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramParameter4(target, index, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameter4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramParameter4(target, index, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameter4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramParameter4(target, index, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameter4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramParameter4(target, index, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameters4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramParameters4(target, index, count, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameters4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramParameters4(target, index, count, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameters4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramParameters4(target, index, count, in v.GetPinnableReference());
        }

        public static unsafe void ProgramParameters4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramParameters4(target, index, count, in v.GetPinnableReference());
        }

        public static unsafe void RequestResidentProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // SpanOverloader
            thisApi.RequestResidentProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void RequestResidentProgram(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // SpanOverloader
            thisApi.RequestResidentProgram(n, in programs.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs1(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs1(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs1(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs1(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs2(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs2(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs2(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs2(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs3(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs3(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs3(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs3(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs4(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs4(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs4(index, count, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs4(this NVVertexProgram thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs4(index, count, in v.GetPinnableReference());
        }

    }
}

