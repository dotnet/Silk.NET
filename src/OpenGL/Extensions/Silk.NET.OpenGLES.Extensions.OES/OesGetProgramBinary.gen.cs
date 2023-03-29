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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_get_program_binary")]
    public unsafe partial class OesGetProgramBinary : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_get_program_binary";
        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] OES* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out OES binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glProgramBinaryOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] OES binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] int length);

        public OesGetProgramBinary(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

