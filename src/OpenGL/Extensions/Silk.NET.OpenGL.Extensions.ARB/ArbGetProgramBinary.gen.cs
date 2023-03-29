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
    [Extension("ARB_get_program_binary")]
    public unsafe partial class ArbGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_get_program_binary";
        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glProgramBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramParameteri", Convention = CallingConvention.Winapi)]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        public ArbGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

