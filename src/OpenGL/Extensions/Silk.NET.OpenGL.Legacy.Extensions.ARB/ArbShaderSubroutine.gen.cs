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
    [Extension("ARB_shader_subroutine")]
    public unsafe partial class ArbShaderSubroutine : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_subroutine";
        [NativeApi(EntryPoint = "glGetActiveSubroutineName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramStageiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramStage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSubroutineIndex", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetSubroutineIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSubroutineUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniformSubroutine([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformSubroutines([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* indices);

        public ArbShaderSubroutine(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

