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
    [Extension("ARB_uniform_buffer_object")]
    public unsafe partial class ArbUniformBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_uniform_buffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* uniformName)
            => ImplGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformName">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> uniformName)
            => ImplGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] char* uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ref char uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] char** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
            => ImplGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] ref char* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices)
            => ImplGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockBinding">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding)
            => ImplUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferBase")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer)
            => ImplBindBufferBase(target, index, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindBufferRange")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplBindBufferRange(target, index, buffer, offset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from program, uniformBlockIndex, and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniformBlock(program, uniformBlockIndex, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName)
            => ImplGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName)
            => ImplGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformIndex">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="uniformName">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName)
            => ImplGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is taken from uniformCount.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from uniformCount and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformBlockName">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName)
            => ImplGetUniformBlockIndex(program, uniformBlockName);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (char**) SilkMarshal.MarshalStringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public ArbUniformBufferObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

