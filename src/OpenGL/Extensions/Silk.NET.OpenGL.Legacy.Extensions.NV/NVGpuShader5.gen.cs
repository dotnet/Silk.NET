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
    [Extension("NV_gpu_shader5")]
    public unsafe partial class NVGpuShader5 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_shader5";
        [NativeApi(EntryPoint = "glGetUniformi64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetUniformi64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glProgramUniform1i64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glProgramUniform1i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform1i64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform2i64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glProgramUniform2i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform2i64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform3i64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glProgramUniform3i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform3i64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform4i64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glProgramUniform4i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform4i64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform1i64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glUniform1i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform1i64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform1ui64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glUniform1ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform1ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform2i64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glUniform2i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform2i64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform2ui64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glUniform2ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform2ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform3i64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glUniform3i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform3i64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform3ui64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glUniform3ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform3ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform4i64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glUniform4i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform4i64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform4ui64NV", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glUniform4ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform4ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public NVGpuShader5(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

