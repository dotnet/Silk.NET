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
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clMemBlockingFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemBlockingFree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemBlockingFreeINTEL", Convention = CallingConvention.Winapi)]
        public partial int MemBlockingFree<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] out T0 ptr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clMemFreeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int MemFree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemFreeINTEL", Convention = CallingConvention.Winapi)]
        public partial int MemFree<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] out T0 ptr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgMemPointer([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL", Convention = CallingConvention.Winapi)]
        public partial int SetKernelArgMemPointer<T0>([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] in T0 arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        public IntelUnifiedSharedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

