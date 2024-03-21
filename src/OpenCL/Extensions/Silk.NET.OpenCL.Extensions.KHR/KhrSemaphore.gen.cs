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
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreProperties* sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreProperties* sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreProperties sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SemaphoreProperties sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateSemaphoreWithPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateSemaphoreWithProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_props, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetSemaphoreInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret);

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public partial int GetSemaphoreInfo<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nuint param_value_size_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clReleaseSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public partial int ReleaseSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object);

        [NativeApi(EntryPoint = "clRetainSemaphoreKHR", Convention = CallingConvention.Winapi)]
        public partial int RetainSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object);

        public KhrSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

