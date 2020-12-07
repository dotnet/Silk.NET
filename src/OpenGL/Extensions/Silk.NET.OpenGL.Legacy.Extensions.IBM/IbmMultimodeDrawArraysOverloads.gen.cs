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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    public static class IbmMultimodeDrawArraysOverloads
    {
        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

    }
}

