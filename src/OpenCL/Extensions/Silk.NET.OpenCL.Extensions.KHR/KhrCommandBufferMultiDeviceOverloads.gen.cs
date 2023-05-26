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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrCommandBufferMultiDeviceOverloads
    {
        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, handles, handles_ret, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, handles, out handles_ret.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, handles, out handles_ret.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, in handles.GetPinnableReference(), handles_ret, errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, in handles.GetPinnableReference(), handles_ret, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, in handles.GetPinnableReference(), out handles_ret.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, queues, num_handles, in handles.GetPinnableReference(), out handles_ret.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, handles, handles_ret, errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, handles, handles_ret, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, handles, out handles_ret.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, handles, out handles_ret.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, in handles.GetPinnableReference(), handles_ret, errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, in handles.GetPinnableReference(), handles_ret, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, in handles.GetPinnableReference(), out handles_ret.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint RemapCommandBuffer(this KhrCommandBufferMultiDevice thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.RemapCommandBuffer(command_buffer, automatic, num_queues, in queues.GetPinnableReference(), num_handles, in handles.GetPinnableReference(), out handles_ret.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

