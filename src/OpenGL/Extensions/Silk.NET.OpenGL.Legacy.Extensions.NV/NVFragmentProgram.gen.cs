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
    [Extension("NV_fragment_program")]
    public unsafe partial class NVFragmentProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_program";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ref byte name, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetProgramNamedParameter(id, len, name, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
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
        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplProgramNamedParameter4(id, len, name, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplProgramNamedParameter4(id, len, name, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In)] string name, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplProgramNamedParameter4(id, len, name, v);

        public NVFragmentProgram(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

