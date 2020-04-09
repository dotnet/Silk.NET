// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_shared_virtual_memory")]
    public abstract unsafe partial class ArmSharedVirtualMemory : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM")]
        public abstract unsafe int EnqueueSvmfree([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM")]
        public abstract int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM")]
        public abstract unsafe int EnqueueSvmmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM")]
        public abstract int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM")]
        public abstract unsafe int EnqueueSvmmemcpy([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM")]
        public abstract int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM")]
        public abstract unsafe int EnqueueSvmmemFill([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM")]
        public abstract int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] UIntPtr pattern_size, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM")]
        public abstract unsafe int EnqueueSvmunmap([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM")]
        public abstract int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSetKernelArgSVMPointerARM")]
        public abstract unsafe int SetKernelArgSvmpointer([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSetKernelArgSVMPointerARM")]
        public abstract int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSetKernelExecInfoARM")]
        public abstract unsafe int SetKernelExecInfo([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] void* param_value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSetKernelExecInfoARM")]
        public abstract int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] IntPtr kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] UIntPtr param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSVMAllocARM")]
        public abstract unsafe void* Svmalloc([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint alignment);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSVMFreeARM")]
        public abstract unsafe void Svmfree([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] void* svm_pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clSVMFreeARM")]
        public abstract void Svmfree<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged;

        public unsafe int EnqueueSvmfree([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmfree<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] Span<T0> svm_pointers, [Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] Span<T1> user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmfree(new IntPtr(command_queue), num_svm_pointers, svm_pointers, pfn_free_func, user_data, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmap(new IntPtr(command_queue), blocking_map, flags, svm_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemcpy([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemcpy<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] Span<T0> dst_ptr, [Flow(FlowDirection.In)] Span<T1> src_ptr, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemcpy(new IntPtr(command_queue), blocking_copy, dst_ptr, src_ptr, new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemFill([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmmemFill<T0, T1>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] Span<T1> pattern, [Flow(FlowDirection.In)] uint pattern_size, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmmemFill(new IntPtr(command_queue), svm_ptr, pattern, new UIntPtr(pattern_size), new UIntPtr(size), num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmunmap([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueSvmunmap<T0>([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.Out)] Span<T0> svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event) where T0 : unmanaged
        {
            // IntPtrOverloader
            return EnqueueSvmunmap(new IntPtr(command_queue), svm_ptr, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int SetKernelArgSvmpointer([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value)
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        public unsafe int SetKernelArgSvmpointer<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] Span<T0> arg_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelArgSvmpointer(new IntPtr(kernel), arg_index, arg_value);
        }

        public unsafe int SetKernelExecInfo([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] void* param_value)
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        public unsafe int SetKernelExecInfo<T0>([Flow(FlowDirection.In)] int kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] uint param_value_size, [Flow(FlowDirection.In)] Span<T0> param_value) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetKernelExecInfo(new IntPtr(kernel), param_name, new UIntPtr(param_value_size), param_value);
        }

        public unsafe void* Svmalloc([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint alignment)
        {
            // IntPtrOverloader
            return Svmalloc(new IntPtr(context), flags, new UIntPtr(size), alignment);
        }

        public unsafe void Svmfree([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] void* svm_pointer)
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        public unsafe void Svmfree<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.Out)] Span<T0> svm_pointer) where T0 : unmanaged
        {
            // IntPtrOverloader
            Svmfree(new IntPtr(context), svm_pointer);
        }

        public ArmSharedVirtualMemory(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

