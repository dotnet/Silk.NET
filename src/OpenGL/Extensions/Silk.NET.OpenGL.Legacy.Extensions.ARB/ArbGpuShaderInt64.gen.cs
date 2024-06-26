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
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetnUniformi64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetnUniformui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetnUniformui64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetUniformi64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetUniformi64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetUniformui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetUniformui64vARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glProgramUniform1i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glProgramUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform2i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glProgramUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform3i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glProgramUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glProgramUniform4i64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glProgramUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glProgramUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glUniform1i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform1i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glUniform1ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform1ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glUniform2i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform2i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glUniform2ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform2ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glUniform3i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform3i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glUniform3ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform3ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        [NativeApi(EntryPoint = "glUniform4i64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] long* value);

        [NativeApi(EntryPoint = "glUniform4i64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in long value);

        [NativeApi(EntryPoint = "glUniform4ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniform4ui64vARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        public unsafe long GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            long ret = default;
            GetnUniform(program, location, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*8, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*8, out @params.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length/1, in value.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length/1, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<long> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe long GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnUniform(program, location, bufSize, out long silkRet);
            return silkRet;
        }

        public unsafe long GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            // NonKhrReturnTypeOverloader
            GetUniform(program, location, out long silkRet);
            return silkRet;
        }

        public ArbGpuShaderInt64(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

