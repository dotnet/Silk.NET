// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    public static class AppleElementArrayOverloads
    {
        public static unsafe void ElementPointer<T0>(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE type, [Count(Computed = "type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ElementPointer(type, in pointer.GetPinnableReference());
        }

        public static unsafe void ElementPointer<T0>(this AppleElementArray thisApi, [Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ElementPointer(type, in pointer.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, primcount);
        }

        public static unsafe void MultiDrawRangeElementArray(this AppleElementArray thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] uint primcount)
        {
            // SpanOverloader
            thisApi.MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), primcount);
        }

    }
}

