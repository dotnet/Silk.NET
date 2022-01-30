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
    [Extension("ARB_ES2_compatibility")]
    public unsafe partial class ArbES2Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES2_compatibility";
        [NativeApi(EntryPoint = "glClearDepthf", Convention = CallingConvention.Winapi)]
        public partial void ClearDepth([Flow(FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glDepthRangef", Convention = CallingConvention.Winapi)]
        public partial void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler", Convention = CallingConvention.Winapi)]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        public unsafe void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public unsafe void ShaderBinary<T0>([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public unsafe void ShaderBinary<T0>([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public unsafe void ShaderBinary<T0>([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public unsafe void ShaderBinary([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public unsafe void ShaderBinary<T0>([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ShaderBinary((uint) shaders.Length, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), (uint) (binary.Length * Unsafe.SizeOf<T0>()));
        }

        public ArbES2Compatibility(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

