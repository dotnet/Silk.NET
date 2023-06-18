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
        public unsafe partial void GetProgramNamedParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramNamedParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramNamedParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramNamedParameter4dvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramNamedParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        public NVFragmentProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

