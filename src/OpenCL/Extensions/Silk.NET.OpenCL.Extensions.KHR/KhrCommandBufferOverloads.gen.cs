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
    public static class KhrCommandBufferOverloads
    {
        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandBarrierWithWaitList(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandBarrierWithWaitList(command_buffer, command_queue, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBuffer(command_buffer, command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferRect(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint src_row_pitch, [Flow(FlowDirection.In)] nuint src_slice_pitch, [Flow(FlowDirection.In)] nuint dst_row_pitch, [Flow(FlowDirection.In)] nuint dst_slice_pitch, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferRect(command_buffer, command_queue, src_buffer, dst_buffer, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyBufferToImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_buffer, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint src_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyBufferToImage(command_buffer, command_queue, src_buffer, dst_image, src_offset, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, src_origin, in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), dst_origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> dst_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImage(command_buffer, command_queue, src_image, dst_image, in src_origin.GetPinnableReference(), in dst_origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] nuint* src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, src_origin, in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), region, dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandCopyImageToBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> src_origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] nuint dst_offset, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandCopyImageToBuffer(command_buffer, command_queue, src_image, dst_buffer, in src_origin.GetPinnableReference(), in region.GetPinnableReference(), dst_offset, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, pattern, pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillBuffer<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillBuffer(command_buffer, command_queue, buffer, in pattern.GetPinnableReference(), pattern_size, offset, size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] void* fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, fill_color, in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] nuint* origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), origin, in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] nuint* region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), region, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandFillImage<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] ReadOnlySpan<T0> fill_color, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> origin, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> region, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CommandFillImage(command_buffer, command_queue, image, in fill_color.GetPinnableReference(), in origin.GetPinnableReference(), in region.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, properties, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] nuint* local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), local_work_size, num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] uint* sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, sync_point_wait_list, out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] uint* sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), sync_point, out mutable_handle.GetPinnableReference());
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] nint* mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), mutable_handle);
        }

        public static unsafe int CommandNdrangeKernel(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> local_work_size, [Flow(FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sync_point_wait_list, [Flow(FlowDirection.Out)] Span<uint> sync_point, [Flow(FlowDirection.Out)] Span<nint> mutable_handle)
        {
            // SpanOverloader
            return thisApi.CommandNdrangeKernel(command_buffer, command_queue, in properties.GetPinnableReference(), kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), in local_work_size.GetPinnableReference(), num_sync_points_in_wait_list, in sync_point_wait_list.GetPinnableReference(), out sync_point.GetPinnableReference(), out mutable_handle.GetPinnableReference());
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] nint* queues, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, queues, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] nint* queues, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, queues, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] nint* queues, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, queues, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, in queues.GetPinnableReference(), properties, errcode_ret);
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, in queues.GetPinnableReference(), properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, in queues.GetPinnableReference(), in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.In)] ReadOnlySpan<nint> queues, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandBuffer(num_queues, in queues.GetPinnableReference(), in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] nint* queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, queues, command_buffer, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] nint* queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, queues, command_buffer, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] nint* queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, queues, command_buffer, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] Span<nint> queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, out queues.GetPinnableReference(), command_buffer, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] Span<nint> queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, out queues.GetPinnableReference(), command_buffer, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] Span<nint> queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, out queues.GetPinnableReference(), command_buffer, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueCommandBuffer(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] uint num_queues, [Flow(FlowDirection.Out)] Span<nint> queues, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueCommandBuffer(num_queues, out queues.GetPinnableReference(), command_buffer, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetCommandBufferInfo(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetCommandBufferInfo(command_buffer, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetCommandBufferInfo<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCommandBufferInfo(command_buffer, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetCommandBufferInfo<T0>(this KhrCommandBuffer thisApi, [Flow(FlowDirection.In)] nint command_buffer, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetCommandBufferInfo(command_buffer, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

