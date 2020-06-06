// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_unified_shared_memory")]
    public unsafe partial class IntelUnifiedSharedMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_unified_shared_memory";
        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplDeviceMemAlloc(context, device, properties, size, alignment, errcode_ret);

        [NativeApi(EntryPoint = "clDeviceMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* DeviceMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplDeviceMemAlloc(context, device, properties, size, alignment, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemAdvise([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMemAdvise(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemAdviseINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueMemAdvise<T0>(command_queue, ptr, size, advice, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMemcpy(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemcpyINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueMemcpy<T0, T1>(command_queue, blocking, dst_ptr, src_ptr, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMemFill(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemFillINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
            => ImplEnqueueMemFill<T0, T1>(command_queue, dst_ptr, pattern, pattern_size, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemset([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMemset(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMemsetINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMemset<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueMemset<T0>(command_queue, dst_ptr, value, size, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMem([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueMigrateMem(command_queue, ptr, size, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
            => ImplEnqueueMigrateMem<T0>(command_queue, ptr, size, flags, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemAllocInfo([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
            => ImplGetMemAllocInfo(context, ptr, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clGetMemAllocInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
            => ImplGetMemAllocInfo<T0, T1>(context, ptr, param_name, param_value_size, param_value, param_value_size_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplHostMemAlloc(context, properties, size, alignment, errcode_ret);

        [NativeApi(EntryPoint = "clHostMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* HostMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplHostMemAlloc(context, properties, size, alignment, errcode_ret);

        [NativeApi(EntryPoint = "clMemFreeINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int MemFree([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] void* ptr)
            => ImplMemFree(context, ptr);

        [NativeApi(EntryPoint = "clMemFreeINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int MemFree<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
            => ImplMemFree<T0>(context, ptr);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgMemPointer([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
            => ImplSetKernelArgMemPointer(kernel, arg_index, arg_value);

        [NativeApi(EntryPoint = "clSetKernelArgMemPointerINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int SetKernelArgMemPointer<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
            => ImplSetKernelArgMemPointer<T0>(kernel, arg_index, arg_value);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplSharedMemAlloc(context, device, properties, size, alignment, errcode_ret);

        [NativeApi(EntryPoint = "clSharedMemAllocINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* SharedMemAlloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplSharedMemAlloc(context, device, properties, size, alignment, errcode_ret);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* DeviceMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return DeviceMemAlloc(new IntPtr(context), new IntPtr(device), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* DeviceMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return DeviceMemAlloc(new IntPtr(context), new IntPtr(device), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemAdvise([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMemAdvise(new IntPtr(command_queue), ptr, new UIntPtr(size), advice, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemAdvise<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint advice, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueMemAdvise(new IntPtr(command_queue), ptr, new UIntPtr(size), advice, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemcpy([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMemcpy(new IntPtr(command_queue), blocking, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemcpy<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueMemcpy(new IntPtr(command_queue), blocking, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemFill([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMemFill(new IntPtr(command_queue), dst_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemFill<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueMemFill(new IntPtr(command_queue), dst_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemset([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMemset(new IntPtr(command_queue), dst_ptr, value, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMemset<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] int value, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueMemset(new IntPtr(command_queue), dst_ptr, value, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMem([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueMigrateMem(new IntPtr(command_queue), ptr, new UIntPtr(size), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueMigrateMem<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueMigrateMem(new IntPtr(command_queue), ptr, new UIntPtr(size), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemAllocInfo([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] UIntPtr* param_value_size_ret)
        {
            // IntPtrOverloader
            return GetMemAllocInfo(new IntPtr(context), ptr, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetMemAllocInfo<T0, T1>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<UIntPtr> param_value_size_ret) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return GetMemAllocInfo(new IntPtr(context), ptr, param_name, new UIntPtr(param_value_size), param_value, param_value_size_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* HostMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return HostMemAlloc(new IntPtr(context), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* HostMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return HostMemAlloc(new IntPtr(context), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int MemFree([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] void* ptr)
        {
            // IntPtrOverloader
            return MemFree(new IntPtr(context), ptr);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int MemFree<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<T0> ptr) where T0 : unmanaged
        {
            // IntPtrOverloader
            return MemFree(new IntPtr(context), ptr);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgMemPointer([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArgMemPointer(new IntPtr(kernel), arg_index, arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int SetKernelArgMemPointer<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArgMemPointer(new IntPtr(kernel), arg_index, arg_value);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* SharedMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return SharedMemAlloc(new IntPtr(context), new IntPtr(device), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* SharedMemAlloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int device, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return SharedMemAlloc(new IntPtr(context), new IntPtr(device), properties, new UIntPtr(size), alignment, errcode_ret);
        }

        public IntelUnifiedSharedMemory(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

