// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_program_interface_query")]
    public unsafe partial class ArbProgramInterfaceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_program_interface_query";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetProgramInterface(program, programInterface, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// This parameter's element count is taken from propCount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceLocation(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetProgramResourceName(program, programInterface, index, bufSize, length, name);

        public ArbProgramInterfaceQuery(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

