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
    [Extension("NV_shader_buffer_load")]
    public unsafe partial class NVShaderBufferLoad : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shader_buffer_load";
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetIntegerui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* result);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetUniformui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glIsBufferResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool IsBufferResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glIsNamedBufferResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool IsNamedBufferResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMakeBufferNonResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeBufferNonResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glMakeBufferResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeBufferResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glMakeNamedBufferNonResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeNamedBufferNonResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMakeNamedBufferResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeNamedBufferResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glProgramUniformui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformui64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        public NVShaderBufferLoad(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

