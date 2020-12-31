// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out bool residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public unsafe partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Boolean* residences);

        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        public partial bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Boolean residences);

        [NativeApi(EntryPoint = "glBindProgramNV")]
        public partial void BindProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindProgramNV")]
        public partial void BindProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        public unsafe partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        public unsafe partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs);

        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs);

        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        public unsafe partial void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        public partial void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        public unsafe partial void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        public partial void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glGenProgramsNV")]
        public unsafe partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* programs);

        [NativeApi(EntryPoint = "glGenProgramsNV")]
        public partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint programs);

        [NativeApi(EntryPoint = "glGenProgramsNV")]
        public unsafe partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Program* programs);

        [NativeApi(EntryPoint = "glGenProgramsNV")]
        public partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Program programs);

        [NativeApi(EntryPoint = "glGetProgramivNV")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivNV")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramivNV")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivNV")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public unsafe partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        public partial void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] byte* program);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] out byte program);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] string program);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] byte* program);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] out byte program);

        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        public partial void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Flow(FlowDirection.Out)] string program);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public unsafe partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        public partial void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glIsProgramNV")]
        public partial bool IsProgram([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public unsafe partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] byte* program);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in byte program);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public partial void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string program);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public unsafe partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] byte* program);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in byte program);

        [NativeApi(EntryPoint = "glLoadProgramNV")]
        public partial void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string program);

        [NativeApi(EntryPoint = "glProgramParameter4dNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramParameter4dNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameter4fNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramParameter4fNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        public unsafe partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        public partial void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        public unsafe partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        public partial void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        public unsafe partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        public partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        public unsafe partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Program* programs);

        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        public partial void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Program programs);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] NV transform);

        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        public partial void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform);

        [NativeApi(EntryPoint = "glVertexAttrib1dNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dvNV")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dvNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib1fNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fvNV")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fvNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib1sNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1svNV")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1svNV")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib2dNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dvNV")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dvNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib2fNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fvNV")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fvNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib2sNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2svNV")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2svNV")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib3dNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dvNV")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dvNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib3fNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fvNV")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fvNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib3sNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3svNV")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3svNV")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4dNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dvNV")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dvNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib4fNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fvNV")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fvNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib4sNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4svNV")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4svNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] VertexAttribEnumNV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] VertexAttribEnumNV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribs1dvNV")]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs1dvNV")]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs1fvNV")]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs1fvNV")]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs1svNV")]
        public unsafe partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs1svNV")]
        public partial void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs2dvNV")]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs2dvNV")]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs2fvNV")]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs2fvNV")]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs2svNV")]
        public unsafe partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs2svNV")]
        public partial void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs3dvNV")]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs3dvNV")]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs3fvNV")]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs3fvNV")]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs3svNV")]
        public unsafe partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs3svNV")]
        public partial void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs4dvNV")]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribs4dvNV")]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribs4fvNV")]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttribs4fvNV")]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribs4svNV")]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribs4svNV")]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        public unsafe partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        public partial void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string v);

        public unsafe void DeleteProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] uint programs)
        {
            // ArrayParameterOverloader
            DeleteProgram(1, &programs);
        }

        public unsafe uint GenProgram()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgram(n, &ret);
            return ret;
        }

        public NVVertexProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

