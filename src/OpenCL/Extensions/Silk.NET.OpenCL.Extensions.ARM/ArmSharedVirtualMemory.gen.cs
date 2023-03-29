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

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_shared_virtual_memory")]
    public unsafe partial class ArmSharedVirtualMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "ARM_shared_virtual_memory";
        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmfree([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_svm_pointers, [Flow(FlowDirection.Out)] void* svm_pointers, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(FlowDirection.Out)] void* user_data, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] MapFlags flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (Bool, MapFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_map, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] bool blocking_copy, [Flow(FlowDirection.Out)] void* dst_ptr, [Flow(FlowDirection.In)] void* src_ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] void* pattern, [Flow(FlowDirection.In)] nuint pattern_size, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.Out)] void* svm_ptr, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointerARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgSvmpointer([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint arg_index, [Flow(FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfoARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelExecInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] KernelExecInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] void* param_value);

        [Obsolete("The \"ungrouped\" enums (ARM) are deprecated in favour of the \"grouped\" enums (KernelExecInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clSetKernelExecInfoARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelExecInfo([Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.In)] void* param_value);

        [NativeApi(EntryPoint = "clSVMAllocARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void* Svmalloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] SvmMemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment);

        [Obsolete("The \"ungrouped\" enums (ARM) are deprecated in favour of the \"grouped\" enums (SvmMemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clSVMAllocARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void* Svmalloc([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint alignment);

        [NativeApi(EntryPoint = "clSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void Svmfree([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.Out)] void* svm_pointer);

        public ArmSharedVirtualMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

