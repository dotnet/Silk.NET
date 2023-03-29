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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public static class OesDrawElementsBaseVertexOverloads
    {
        public static unsafe void DrawElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsBaseVertex(mode, count, type, indicesSpp, basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsBaseVertex(mode, count, type, indicesSpp, basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsBaseVertex(mode, count, type, indicesSpp, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstancedBaseVertex(mode, count, type, indicesSpp, instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstancedBaseVertex(mode, count, type, indicesSpp, instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstancedBaseVertex(mode, count, type, indicesSpp, instancecount, basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, indicesSpp, basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] OES type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, indicesSpp, basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, indicesSpp, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] OES mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this OesDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

    }
}

