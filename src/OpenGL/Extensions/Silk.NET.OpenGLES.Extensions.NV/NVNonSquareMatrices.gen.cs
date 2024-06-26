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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_non_square_matrices")]
    public unsafe partial class NVNonSquareMatrices : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_non_square_matrices";
        [NativeApi(EntryPoint = "glUniformMatrix2x3fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fvNV", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        public unsafe void UniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x3(location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2x4(location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x2(location, (uint) value.Length/6, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3x4(location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x2(location, (uint) value.Length/8, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4x3(location, (uint) value.Length/12, transpose, in value.GetPinnableReference());
        }

        public NVNonSquareMatrices(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

