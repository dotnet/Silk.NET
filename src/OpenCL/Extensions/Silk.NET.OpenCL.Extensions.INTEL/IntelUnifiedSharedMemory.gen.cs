// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_unified_shared_memory")]
    public unsafe partial class IntelUnifiedSharedMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_unified_shared_memory";
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        public unsafe partial void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public unsafe partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        public partial int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public unsafe partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        public partial int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] in T0 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public unsafe partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        public partial int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] in T1 pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public unsafe partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        public partial int EnqueueMemset<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] out T0 dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public unsafe partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        public partial int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public unsafe partial int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        public partial int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] out T1 param_value, [Flow(FlowDirection.Out)] out UIntPtr param_value_size_ret) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        public unsafe partial void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clMemFreeINTEL")]
        public unsafe partial int MemFree([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] void* ptr);

        [NativeApi(EntryPoint = "clMemFreeINTEL")]
        public partial int MemFree<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] out T0 ptr) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL")]
        public unsafe partial int SetKernelArgMemPointer([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL")]
        public partial int SetKernelArgMemPointer<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] in T0 arg_value) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        public unsafe partial void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] out int errcode_ret);

        public IntelUnifiedSharedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

