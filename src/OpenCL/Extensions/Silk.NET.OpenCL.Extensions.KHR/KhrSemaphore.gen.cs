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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_semaphore")]
    public unsafe partial class KhrSemaphore : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_semaphore";
        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ulong* sema_props, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ulong* sema_props, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in ulong sema_props, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateSemaphoreWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in ulong sema_props, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSignalSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] nint* sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] ulong* sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWaitSemaphores([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_sema_objects, [Flow(FlowDirection.In)] in nint sema_objects, [Flow(FlowDirection.In)] in ulong sema_payload_list, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] void* param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo<T0>([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetSemaphoreInfo<T0>([Flow(FlowDirection.In)] nint sema_object, [Flow(FlowDirection.In)] KHR param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] out T0 param_value, [Flow(FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public partial int ReleaseSemaphore([Flow(FlowDirection.In)] nint sema_object);

        [NativeApi(EntryPoint = "clRetainSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public partial int RetainSemaphore([Flow(FlowDirection.In)] nint sema_object);

        public KhrSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

