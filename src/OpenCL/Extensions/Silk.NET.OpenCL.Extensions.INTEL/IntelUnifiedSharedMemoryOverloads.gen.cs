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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelUnifiedSharedMemoryOverloads
    {
        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* DeviceMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.DeviceMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMemAdvise(command_queue, ptrSpp, size, advice, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMemAdvise(command_queue, ptrSpp, size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemAdvise<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMemAdvise(command_queue, ptrSpp, size, advice, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemcpy<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* src_ptrSpp = src_ptr)
                return thisApi.EnqueueMemcpy(command_queue, blocking, dst_ptrSpp, src_ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueMemFill(command_queue, dst_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueMemFill(command_queue, dst_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemFill<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
            fixed (void* patternSpp = pattern)
                return thisApi.EnqueueMemFill(command_queue, dst_ptrSpp, patternSpp, pattern_size, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
                return thisApi.EnqueueMemset(command_queue, dst_ptrSpp, value, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
                return thisApi.EnqueueMemset(command_queue, dst_ptrSpp, value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMemset<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dst_ptrSpp = dst_ptr)
                return thisApi.EnqueueMemset(command_queue, dst_ptrSpp, value, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int EnqueueMigrateMem<T0>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueMigrateMem(command_queue, ptrSpp, size, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetMemAllocInfo<T0, T1>(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetMemAllocInfo(context, ptrSpp, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* HostMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.HostMemAlloc(context, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, properties, size, alignment, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe void* SharedMemAlloc(this IntelUnifiedSharedMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.SharedMemAlloc(context, device, in properties.GetPinnableReference(), size, alignment, out errcode_ret.GetPinnableReference());
        }

    }
}

