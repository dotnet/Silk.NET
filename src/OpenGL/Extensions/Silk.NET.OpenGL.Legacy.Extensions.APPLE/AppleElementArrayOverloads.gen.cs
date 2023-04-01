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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    public static class AppleElementArrayOverloads
    {
        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

    }
}

