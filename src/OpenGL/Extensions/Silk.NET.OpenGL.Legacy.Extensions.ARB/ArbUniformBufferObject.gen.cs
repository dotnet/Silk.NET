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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_uniform_buffer_object")]
    public unsafe partial class ArbUniformBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_uniform_buffer_object";
        [NativeApi(EntryPoint = "glBindBufferBase", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferBase", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glBindBufferRange", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetUniformBlockIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetUniformBlockIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex", Convention = CallingConvention.Winapi)]
        public partial uint GetUniformBlockIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glUniformBlockBinding", Convention = CallingConvention.Winapi)]
        public partial void UniformBlockBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockBinding);

        public unsafe void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, (uint) uniformBlockName.Length, length, out uniformBlockName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, (uint) uniformBlockName.Length, length, out uniformBlockName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformBlockName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, (uint) uniformBlockName.Length, out length, out uniformBlockName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformBlockName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, (uint) uniformBlockName.Length, out length, out uniformBlockName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformName(program, uniformIndex, (uint) uniformName.Length, length, out uniformName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformName(program, uniformIndex, (uint) uniformName.Length, length, out uniformName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> uniformName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformName(program, uniformIndex, (uint) uniformName.Length, out length, out uniformName.GetPinnableReference());
        }

        public unsafe void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> uniformName)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniformName(program, uniformIndex, (uint) uniformName.Length, out length, out uniformName.GetPinnableReference());
        }

        public unsafe void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniforms(program, (uint) uniformIndices.Length, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public unsafe void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniforms(program, (uint) uniformIndices.Length, in uniformIndices.GetPinnableReference(), pname, out @params);
        }

        public unsafe void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniforms(program, (uint) uniformIndices.Length, in uniformIndices.GetPinnableReference(), pname, @params);
        }

        public unsafe void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniforms(program, (uint) uniformIndices.Length, in uniformIndices.GetPinnableReference(), pname, out @params);
        }

        public unsafe void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.StringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((nint) uniformNames, uniformNamesSa);
            SilkMarshal.Free((nint) uniformNames);
        }

        public unsafe void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.StringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
            SilkMarshal.CopyPtrToStringArray((nint) uniformNames, uniformNamesSa);
            SilkMarshal.Free((nint) uniformNames);
        }

        public unsafe int GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformBlock(program, uniformBlockIndex, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformBlockPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformBlock(program, uniformBlockIndex, pname, out int silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformName(program, uniformIndex, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniformName(program, uniformIndex, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformCount, uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformCount, in uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformCount, uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformCount, in uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetInteger(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetInteger(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe uint GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames)
        {
            // NonKhrReturnTypeOverloader
            GetUniformIndices(program, uniformCount, uniformNames, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* uniformNames)
        {
            // NonKhrReturnTypeOverloader
            GetUniformIndices(program, uniformCount, in uniformNames, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UniformPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniforms(program, uniformIndices, pname, out int silkRet);
            return silkRet;
        }

        public unsafe uint GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] uniformNamesSa)
        {
            // NonKhrReturnTypeOverloader
            GetUniformIndices(program, uniformCount, uniformNamesSa, out uint silkRet);
            return silkRet;
        }

        public ArbUniformBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

