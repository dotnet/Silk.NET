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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelUnifiedSharedMemoryOverloads
    {
        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, ptr, size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemAdvise(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, ptr, size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, in ptr.GetPinnableReference(), size, advice, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, in ptr.GetPinnableReference(), size, advice, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, in ptr.GetPinnableReference(), size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemAdvise(command_queue, in ptr.GetPinnableReference(), size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemcpy(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemcpy<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemcpy(command_queue, blocking, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemFill(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, dst_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemFill<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemFill(command_queue, out dst_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, dst_ptr, value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemset(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, dst_ptr, value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, out dst_ptr.GetPinnableReference(), value, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, out dst_ptr.GetPinnableReference(), value, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, out dst_ptr.GetPinnableReference(), value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMemset(command_queue, out dst_ptr.GetPinnableReference(), value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, ptr, size, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, ptr, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMem(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, ptr, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, in ptr.GetPinnableReference(), size, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, in ptr.GetPinnableReference(), size, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, in ptr.GetPinnableReference(), size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMem(command_queue, in ptr.GetPinnableReference(), size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetMemAllocInfo(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, ptr, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMemAllocInfo<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetMemAllocInfo<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, ptr, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMemAllocInfo<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetMemAllocInfo<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, in ptr.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetMemAllocInfo<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetMemAllocInfo<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemAllocInfo(context, in ptr.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int MemFree<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.MemFree(context, out ptr.GetPinnableReference());
        }

        public static unsafe int SetKernelArgMemPointer<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] ReadOnlySpan<T0> arg_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelArgMemPointer(kernel, arg_index, in arg_value.GetPinnableReference());
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

    }
}

