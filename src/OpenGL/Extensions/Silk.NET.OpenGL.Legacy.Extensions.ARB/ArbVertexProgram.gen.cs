// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_program")]
    public unsafe partial class ArbVertexProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_program";
        [NativeApi(EntryPoint = "glBindProgramARB")]
        public partial void BindProgram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteProgramsARB")]
        public unsafe partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glDeleteProgramsARB")]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> programs);

        [NativeApi(EntryPoint = "glDisableVertexAttribArrayARB")]
        public partial void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexAttribArrayARB")]
        public partial void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGenProgramsARB")]
        public unsafe partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* programs);

        [NativeApi(EntryPoint = "glGenProgramsARB")]
        public partial void GenProgram([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> programs);

        [NativeApi(EntryPoint = "glGetProgramivARB")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivARB")]
        public partial void GetProgram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB")]
        public unsafe partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB")]
        public partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB")]
        public unsafe partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB")]
        public partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB")]
        public unsafe partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB")]
        public partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB")]
        public unsafe partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB")]
        public partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetProgramStringARB")]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetProgramStringARB")]
        public partial void GetProgramString<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public unsafe partial void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsProgramARB")]
        public partial bool IsProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB")]
        public unsafe partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB")]
        public unsafe partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB")]
        public unsafe partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB")]
        public unsafe partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        [NativeApi(EntryPoint = "glProgramStringARB")]
        public unsafe partial void ProgramString([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glProgramStringARB")]
        public partial void ProgramString<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttrib1dARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dvARB")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dvARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glVertexAttrib1fARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fvARB")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fvARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glVertexAttrib1sARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1svARB")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1svARB")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [NativeApi(EntryPoint = "glVertexAttrib2dARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dvARB")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dvARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib2fARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fvARB")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fvARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib2sARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2svARB")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2svARB")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib3dARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dvARB")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dvARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib3fARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fvARB")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fvARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib3sARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3svARB")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3svARB")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4bvARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4bvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4dARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dvARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib4fARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fvARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib4ivARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ivARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4sARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4svARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4svARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4uivARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4uivARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4usvARB")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4usvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NivARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NivARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindProgramARB")]
        public partial void BindProgram([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glGetProgramivARB")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramivARB")]
        public partial void GetProgram([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB")]
        public unsafe partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB")]
        public partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB")]
        public unsafe partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB")]
        public partial void GetProgramEnvParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB")]
        public unsafe partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB")]
        public partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB")]
        public unsafe partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB")]
        public partial void GetProgramLocalParameter([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetProgramStringARB")]
        public unsafe partial void GetProgramString([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetProgramStringARB")]
        public partial void GetProgramString<T0>([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB")]
        public unsafe partial void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramEnvParameter4dARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB")]
        public unsafe partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB")]
        public unsafe partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB")]
        public partial void ProgramEnvParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB")]
        public unsafe partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB")]
        public unsafe partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB")]
        public partial void ProgramLocalParameter4([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        [NativeApi(EntryPoint = "glProgramStringARB")]
        public unsafe partial void ProgramString([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glProgramStringARB")]
        public partial void ProgramString<T0>([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

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

        public ArbVertexProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

