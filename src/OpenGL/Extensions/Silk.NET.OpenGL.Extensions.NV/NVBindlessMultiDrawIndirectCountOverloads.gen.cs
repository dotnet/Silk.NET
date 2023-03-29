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

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVBindlessMultiDrawIndirectCountOverloads
    {
        public static unsafe void MultiDrawArraysIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawArraysIndirectBindlessCount(mode, indirectSpp, drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, indirectSpp, drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, indirectSpp, drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, indirectSpp, drawCount, maxDrawCount, stride, vertexBufferCount);
        }

    }
}

