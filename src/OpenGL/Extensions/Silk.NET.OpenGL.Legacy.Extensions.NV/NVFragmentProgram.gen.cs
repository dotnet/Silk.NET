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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_fragment_program")]
    public unsafe partial class NVFragmentProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_program";
        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramNamedParameter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] in byte name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramNamedParameter4([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        public NVFragmentProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

