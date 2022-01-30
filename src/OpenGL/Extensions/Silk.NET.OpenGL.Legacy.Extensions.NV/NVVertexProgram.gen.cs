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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_program")]
    public unsafe partial class NVVertexProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_program";
        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glBindProgramNV", Convention = CallingConvention.Winapi)]
        public partial void BindProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindProgramNV", Convention = CallingConvention.Winapi)]
        public partial void BindProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs);

        [NativeApi(EntryPoint = "glExecuteProgramNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV", Convention = CallingConvention.Winapi)]
        public partial void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV", Convention = CallingConvention.Winapi)]
        public partial void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glGenProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* programs);

        [NativeApi(EntryPoint = "glGenProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint programs);

        [NativeApi(EntryPoint = "glGenProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Program* programs);

        [NativeApi(EntryPoint = "glGenProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Program programs);

        [NativeApi(EntryPoint = "glGetProgramivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] byte* program);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] out byte program);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string program);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] byte* program);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] out byte program);

        [NativeApi(EntryPoint = "glGetProgramStringNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string program);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV", Convention = CallingConvention.Winapi)]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glIsProgramNV", Convention = CallingConvention.Winapi)]
        public partial bool IsProgram([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] byte* program);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in byte program);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string program);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] byte* program);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in byte program);

        [NativeApi(EntryPoint = "glLoadProgramNV", Convention = CallingConvention.Winapi)]
        public partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string program);

        [NativeApi(EntryPoint = "glProgramParameter4dNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramParameter4dNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameter4fNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramParameter4fNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV", Convention = CallingConvention.Winapi)]
        public partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV", Convention = CallingConvention.Winapi)]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glVertexAttrib1dNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib1fNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib1sNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib2dNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib2fNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib2sNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib3dNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib3fNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib3sNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4dNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib4fNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib4sNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glVertexAttribPointerNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] VertexAttribEnumNV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribs1dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs1dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs1fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs1fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs1svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs1svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs2dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs2dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs2fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs2fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs2svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs2svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs3dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs3dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs3fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs3fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs3svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs3svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs4dvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs4fvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs4svNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs4svNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, programs, out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) programs.Length, in programs.GetPinnableReference(), residences);
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, programs, out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) programs.Length, in programs.GetPinnableReference(), residences);
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, programs, out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) programs.Length, in programs.GetPinnableReference(), residences);
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, programs, out residences.GetPinnableReference());
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) programs.Length, in programs.GetPinnableReference(), residences);
        }

        public unsafe bool AreProgramsResident([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Boolean> residences)
        {
            // ImplicitCountSpanOverloader
            return AreProgramsResident((uint) residences.Length, in programs.GetPinnableReference(), out residences.GetPinnableReference());
        }

        public unsafe void DeleteProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] uint programs)
        {
            // ArrayParameterOverloader
            DeleteProgram(1, &programs);
        }

        public unsafe void DeleteProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // ImplicitCountSpanOverloader
            DeleteProgram((uint) programs.Length, in programs.GetPinnableReference());
        }

        public unsafe void DeleteProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // ImplicitCountSpanOverloader
            DeleteProgram((uint) programs.Length, in programs.GetPinnableReference());
        }

        public unsafe uint GenProgram()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgram(n, &ret);
            return ret;
        }

        public unsafe void GenProgram([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> programs)
        {
            // ImplicitCountSpanOverloader
            GenProgram((uint) programs.Length, out programs.GetPinnableReference());
        }

        public unsafe void GenProgram([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Program> programs)
        {
            // ImplicitCountSpanOverloader
            GenProgram((uint) programs.Length, out programs.GetPinnableReference());
        }

        public unsafe void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<byte> program)
        {
            // ImplicitCountSpanOverloader
            LoadProgram(target, id, (uint) program.Length, in program.GetPinnableReference());
        }

        public unsafe void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<byte> program)
        {
            // ImplicitCountSpanOverloader
            LoadProgram(target, id, (uint) program.Length, in program.GetPinnableReference());
        }

        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            ProgramParameters4(target, index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            ProgramParameters4(target, index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            ProgramParameters4(target, index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            ProgramParameters4(target, index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void RequestResidentProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> programs)
        {
            // ImplicitCountSpanOverloader
            RequestResidentProgram((uint) programs.Length, in programs.GetPinnableReference());
        }

        public unsafe void RequestResidentProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Program> programs)
        {
            // ImplicitCountSpanOverloader
            RequestResidentProgram((uint) programs.Length, in programs.GetPinnableReference());
        }

        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs1(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs1(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs1(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs2(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs2(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs2(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs3(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs3(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs3(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs4(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs4(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs4(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // ImplicitCountSpanOverloader
            VertexAttribs4(index, (uint) v.Length, in v.GetPinnableReference());
        }

        public NVVertexProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

