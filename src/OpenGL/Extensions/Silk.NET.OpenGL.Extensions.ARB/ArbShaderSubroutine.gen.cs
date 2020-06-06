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
    [Extension("ARB_shader_subroutine")]
    public unsafe partial class ArbShaderSubroutine : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_subroutine";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values)
            => ImplGetActiveSubroutineUniform(program, shadertype, index, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values)
            => ImplGetActiveSubroutineUniform(program, shadertype, index, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values)
            => ImplGetProgramStage(program, shadertype, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values)
            => ImplGetProgramStage(program, shadertype, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] char* name)
            => ImplGetSubroutineIndex(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetSubroutineIndex(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] char* name)
            => ImplGetSubroutineUniformLocation(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetSubroutineUniformLocation(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetUniformSubroutine(shadertype, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetUniformSubroutine(shadertype, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices)
            => ImplUniformSubroutines(shadertype, count, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices)
            => ImplUniformSubroutines(shadertype, count, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values)
            => ImplGetActiveSubroutineUniform(program, shadertype, index, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values)
            => ImplGetActiveSubroutineUniform(program, shadertype, index, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
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
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name)
            => ImplGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values)
            => ImplGetProgramStage(program, shadertype, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values)
            => ImplGetProgramStage(program, shadertype, pname, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name)
            => ImplGetSubroutineIndex(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name)
            => ImplGetSubroutineUniformLocation(program, shadertype, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetUniformSubroutine(shadertype, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetUniformSubroutine(shadertype, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices)
            => ImplUniformSubroutines(shadertype, count, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices)
            => ImplUniformSubroutines(shadertype, count, indices);

        public ArbShaderSubroutine(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

