// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public static class ArbGlSpirvOverloads
    {
        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, pConstantIndex, pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, in pEntryPoint.GetPinnableReference(), numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, in pConstantValue.GetPinnableReference());
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), pConstantValue);
        }

        public static unsafe void SpecializeShader(this ArbGlSpirv thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantIndex, [Flow(FlowDirection.In)] ReadOnlySpan<uint> pConstantValue)
        {
            // SpanOverloader
            thisApi.SpecializeShader(shader, pEntryPoint, numSpecializationConstants, in pConstantIndex.GetPinnableReference(), in pConstantValue.GetPinnableReference());
        }

    }
}

