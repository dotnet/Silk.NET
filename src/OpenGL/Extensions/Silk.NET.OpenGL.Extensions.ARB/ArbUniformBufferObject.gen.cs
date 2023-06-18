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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_uniform_buffer_object")]
    public unsafe partial class ArbUniformBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_uniform_buffer_object";
        [NativeApi(EntryPoint = "glBindBufferBase", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformBlockName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniforms([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* uniformIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "uniformCount, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetIntegeri_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetUniformBlockIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glUniformBlockBinding", Convention = CallingConvention.Winapi)]
        public partial void UniformBlockBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uniformBlockBinding);

        public ArbUniformBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

