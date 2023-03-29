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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_unified_shared_memory")]
    public unsafe partial class IntelUnifiedSharedMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_unified_shared_memory";
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] MemMigrationFlags flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clMemBlockingFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemBlockingFree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemFree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgMemPointer([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        public unsafe int DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public IntelUnifiedSharedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

