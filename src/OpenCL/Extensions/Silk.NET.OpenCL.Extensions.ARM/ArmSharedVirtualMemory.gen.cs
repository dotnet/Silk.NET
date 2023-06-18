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
        public unsafe partial int EnqueueSvmfree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointers, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] FreeCallback pfn_free_func, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemcpyARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemcpy([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_copy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dst_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMMemFillARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmmemFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSVMUnmapARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSvmunmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clSetKernelArgSVMPointerARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelArgSvmpointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* arg_value);

        [NativeApi(EntryPoint = "clSetKernelExecInfoARM", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetKernelExecInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KernelExecInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* param_value);

        [NativeApi(EntryPoint = "clSVMAllocARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void* Svmalloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvmMemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint alignment);

        [NativeApi(EntryPoint = "clSVMFreeARM", Convention = CallingConvention.Winapi)]
        public unsafe partial void Svmfree([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* svm_pointer);

        public ArmSharedVirtualMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

