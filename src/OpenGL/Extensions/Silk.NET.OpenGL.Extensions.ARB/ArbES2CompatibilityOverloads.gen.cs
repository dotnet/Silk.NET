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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbES2CompatibilityOverloads
    {
        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, range, out precision.GetPinnableReference());
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), precision);
        }

        public static unsafe void GetShaderPrecisionFormat(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> precision)
        {
            // SpanOverloader
            thisApi.GetShaderPrecisionFormat(shadertype, precisiontype, out range.GetPinnableReference(), out precision.GetPinnableReference());
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, shaders, binaryFormat, in binary.GetPinnableReference(), length);
        }

        public static unsafe void ShaderBinary(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, binary, length);
        }

        public static unsafe void ShaderBinary<T0>(this ArbES2Compatibility thisApi, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Shader> shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ShaderBinary(count, in shaders.GetPinnableReference(), binaryFormat, in binary.GetPinnableReference(), length);
        }

    }
}

