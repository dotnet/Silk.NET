// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_program")]
    public unsafe partial class NVVertexProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_program";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <param name="residences">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences)
            => ImplAreProgramsResident(n, programs, residences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <param name="residences">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glAreProgramsResidentNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool AreProgramsResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> programs, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences)
            => ImplAreProgramsResident(n, programs, residences);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id)
            => ImplBindProgram(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs)
            => ImplDeleteProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> programs)
            => ImplDeleteProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params)
            => ImplExecuteProgram(target, id, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ExecuteProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params)
            => ImplExecuteProgram(target, id, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* programs)
            => ImplGenProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> programs)
            => ImplGenProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgram(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgram(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// This parameter's element count is computed from id and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] byte* program)
            => ImplGetProgramString(id, pname, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// This parameter's element count is computed from id and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "id, pname"), Flow(FlowDirection.Out)] out byte program)
            => ImplGetProgramString(id, pname, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTrackMatrix(target, address, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTrackMatrix(target, address, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer)
            => ImplGetVertexAttribPointer(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged
            => ImplGetVertexAttribPointer<T0>(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsProgram([Flow(FlowDirection.In)] uint id)
            => ImplIsProgram(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glLoadProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] byte* program)
            => ImplLoadProgram(target, id, len, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glLoadProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadProgram([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<byte> program)
            => ImplLoadProgram(target, id, len, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramParameter4(target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplProgramParameter4(target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameters4([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs)
            => ImplRequestResidentProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glRequestResidentProgramsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RequestResidentProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> programs)
            => ImplRequestResidentProgram(n, programs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="matrix">
        /// To be added.
        /// </param>
        /// <param name="transform">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TrackMatrix([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] NV matrix, [Flow(FlowDirection.In)] NV transform)
            => ImplTrackMatrix(target, address, matrix, transform);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x)
            => ImplVertexAttrib1(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x)
            => ImplVertexAttrib1(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1sNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x)
            => ImplVertexAttrib1(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v)
            => ImplVertexAttrib1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y)
            => ImplVertexAttrib2(index, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplVertexAttrib2(index, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2sNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y)
            => ImplVertexAttrib2(index, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttrib2(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplVertexAttrib3(index, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplVertexAttrib3(index, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3sNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z)
            => ImplVertexAttrib3(index, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttrib3(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplVertexAttrib4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplVertexAttrib4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4sNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w)
            => ImplVertexAttrib4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4ubNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w)
            => ImplVertexAttrib4(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="fsize">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from fsize, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribPointer(index, fsize, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="fsize">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from fsize, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribPointer<T0>(index, fsize, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttribs1(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttribs2(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttribs3(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] short* v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4svNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<short> v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte* v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<byte> v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id)
            => ImplBindProgram(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] float* @params)
            => ImplExecuteProgram(target, id, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExecuteProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ExecuteProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params)
            => ImplExecuteProgram(target, id, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgram(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgram([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgram(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramParameter([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramParameter(target, index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramString([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Flow(FlowDirection.Out)] string program)
            => ImplGetProgramString(id, pname, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTrackMatrix(target, address, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetTrackMatrixivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTrackMatrix(target, address, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] double* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out double @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVertexAttrib(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer)
            => ImplGetVertexAttribPointer(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribPointervNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnumNV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged
            => ImplGetVertexAttribPointer<T0>(index, pname, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="program">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLoadProgramNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadProgram([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string program)
            => ImplLoadProgram(target, id, len, program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramParameter4(target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplProgramParameter4(target, index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameter4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramParameter4(target, index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramParameters4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramParameters4([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramParameters4(target, index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="matrix">
        /// To be added.
        /// </param>
        /// <param name="transform">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTrackMatrixNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TrackMatrix([Flow(FlowDirection.In)] VertexAttribEnumNV target, [Flow(FlowDirection.In)] uint address, [Flow(FlowDirection.In)] VertexAttribEnumNV matrix, [Flow(FlowDirection.In)] VertexAttribEnumNV transform)
            => ImplTrackMatrix(target, address, matrix, transform);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v)
            => ImplVertexAttrib4(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="fsize">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from fsize, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] VertexAttribEnumNV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexAttribPointer(index, fsize, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="fsize">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from fsize, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribPointerNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int fsize, [Flow(FlowDirection.In)] VertexAttribEnumNV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "fsize, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexAttribPointer<T0>(index, fsize, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4ubvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] string v)
            => ImplVertexAttribs4(index, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteProgram([Count(Parameter = "n"), Flow(FlowDirection.In)] uint programs)
        {
            // ArrayParameterOverloader
            DeleteProgram(1, &programs);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
            InitializeNative();
        }
    }
}

