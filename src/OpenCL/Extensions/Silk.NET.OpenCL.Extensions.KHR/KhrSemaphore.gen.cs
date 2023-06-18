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

        [NativeApi(EntryPoint = "clEnqueueSignalSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueSignalSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWaitSemaphoresKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWaitSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* sema_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sema_payload_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clGetSemaphoreInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSemaphoreInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

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

