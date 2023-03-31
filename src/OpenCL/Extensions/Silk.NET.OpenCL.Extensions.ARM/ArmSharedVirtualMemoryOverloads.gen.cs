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

namespace Silk.NET.OpenCL.Extensions.ARM
{
    public static class ArmSharedVirtualMemoryOverloads
    {
        public static unsafe int EnqueueSvmfree(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, user_data, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, out svm_pointers.GetPinnableReference(), pfn_free_func, out user_data.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, out svm_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptr, in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), src_ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, out dst_ptr.GetPinnableReference(), in src_ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, svm_ptr, in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), pattern, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmmemFill(command_queue, out svm_ptr.GetPinnableReference(), in pattern.GetPinnableReference(), pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmunmap(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, svm_ptr, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueSvmunmap(command_queue, out svm_ptr.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int SetKernelArgSvmpointer<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> arg_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelArgSvmpointer(kernel, arg_index, in arg_value.GetPinnableReference());
        }

        public static unsafe int SetKernelExecInfo<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelExecInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> param_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelExecInfo(kernel, param_name, param_value_size, in param_value.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (ARM) are deprecated in favour of the \"grouped\" enums (KernelExecInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int SetKernelExecInfo<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> param_value) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetKernelExecInfo(kernel, param_name, param_value_size, in param_value.GetPinnableReference());
        }

        public static unsafe void Svmfree<T0>(this ArmSharedVirtualMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Svmfree(context, out svm_pointer.GetPinnableReference());
        }

    }
}

