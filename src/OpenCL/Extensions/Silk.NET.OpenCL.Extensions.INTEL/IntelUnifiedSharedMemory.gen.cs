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
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemAdvise<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint advice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemcpy<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemFill<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemset<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMem<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetMemAllocInfo<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clMemBlockingFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemBlockingFree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemBlockingFreeINTEL", Convention = CallingConvention.Winapi)]
        public partial int MemBlockingFree<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 ptr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clMemFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemFree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemFreeINTEL", Convention = CallingConvention.Winapi)]
        public partial int MemFree<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 ptr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgMemPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL", Convention = CallingConvention.Winapi)]
        public partial int SetKernelArgMemPointer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        public unsafe int DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int DeviceMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            DeviceMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int HostMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            HostMemAlloc(context, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        public unsafe int SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemProperties properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, in properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
        {
            // NonKhrReturnTypeOverloader
            SharedMemAlloc(context, device, properties, size, alignment, out int silkRet);
            return silkRet;
        }

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (MemProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public unsafe int SharedMemAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CLEnum properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment)
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

