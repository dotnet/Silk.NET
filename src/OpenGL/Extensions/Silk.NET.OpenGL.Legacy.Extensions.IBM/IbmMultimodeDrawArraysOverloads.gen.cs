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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    public static class IbmMultimodeDrawArraysOverloads
    {
        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), first, in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), count, primcount, modestride);
        }

        public static unsafe void MultiModeDrawArrays(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawArrays(in mode.GetPinnableReference(), in first.GetPinnableReference(), in count.GetPinnableReference(), primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<IBM> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), count, type, in indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, indices, primcount, modestride);
        }

        public static unsafe void MultiModeDrawElements(this IbmMultimodeDrawArrays thisApi, [Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PrimitiveType> mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // SpanOverloader
            thisApi.MultiModeDrawElements(in mode.GetPinnableReference(), in count.GetPinnableReference(), type, in indices, primcount, modestride);
        }

    }
}

