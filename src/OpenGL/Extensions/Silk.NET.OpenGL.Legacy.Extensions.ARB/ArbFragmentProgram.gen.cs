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
    [Extension("ARB_fragment_program")]
    public unsafe partial class ArbFragmentProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_fragment_program";
        [NativeApi(EntryPoint = "glBindProgramARB", Convention = CallingConvention.Winapi)]
        public partial void BindProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteProgramsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glGenProgramsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs);

        [NativeApi(EntryPoint = "glGetProgramivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glIsProgramARB", Convention = CallingConvention.Winapi)]
        public partial bool IsProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @string);

        public ArbFragmentProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

