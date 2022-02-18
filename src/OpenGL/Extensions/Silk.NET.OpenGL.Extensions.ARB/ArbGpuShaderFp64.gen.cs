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
    [Extension("ARB_gpu_shader_fp64")]
    public unsafe partial class ArbGpuShaderFp64 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_gpu_shader_fp64";
        [NativeApi(EntryPoint = "glGetUniformdv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetUniformdv", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glUniform1d", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glUniform1dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform1dv", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniform2d", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glUniform2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform2dv", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniform3d", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glUniform3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform3dv", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniform4d", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glUniform4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform4dv", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x2(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x3(location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public ArbGpuShaderFp64(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

