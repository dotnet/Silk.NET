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
    [Extension("ARB_gpu_shader_int64")]
    public unsafe partial class ArbGpuShaderInt64 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_gpu_shader_int64";
        [NativeApi(EntryPoint = "glGetnUniformi64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetnUniformi64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetnUniformui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetnUniformui64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetUniformi64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetUniformi64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetUniformui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetUniformui64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glProgramUniform1i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glProgramUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform2i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glProgramUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform3i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glProgramUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform4i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glProgramUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform1i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform1ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform2i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform2ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform3i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform3ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniform4i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in long value);

        [NativeApi(EntryPoint = "glUniform4ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

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

        public ArbGpuShaderInt64(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

