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
        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_pointersSpp = svm_pointers)
            fixed (void* user_dataSpp = user_data)
                return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointersSpp, pfn_free_func, user_dataSpp, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_pointersSpp = svm_pointers)
            fixed (void* user_dataSpp = user_data)
                return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointersSpp, pfn_free_func, user_dataSpp, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmfree<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_pointersSpp = svm_pointers)
            fixed (void* user_dataSpp = user_data)
                return thisApi.EnqueueSvmfree(command_queue, num_svm_pointers, svm_pointersSpp, pfn_free_func, user_dataSpp, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueSvmmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmmap(command_queue, blocking_map, flags, svm_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemcpy<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueSvmmemcpy(command_queue, blocking_copy, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueSvmmemFill(command_queue, svm_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueSvmmemFill(command_queue, svm_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmmemFill<T0, T1>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueSvmmemFill(command_queue, svm_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmunmap(command_queue, svm_ptrSpp, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmunmap(command_queue, svm_ptrSpp, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueSvmunmap<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* svm_ptrSpp = svm_ptr)
                return thisApi.EnqueueSvmunmap(command_queue, svm_ptrSpp, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (ARM) are deprecated in favour of the \"grouped\" enums (KernelExecInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int SetKernelExecInfo<T0>(this ArmSharedVirtualMemory thisApi, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.SetKernelExecInfo(kernel, param_name, param_value_size, param_valueSpp);
        }

    }
}

