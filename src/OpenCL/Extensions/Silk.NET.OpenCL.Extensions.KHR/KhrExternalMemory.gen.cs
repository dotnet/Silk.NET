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
    [Extension("KHR_external_memory")]
    public unsafe partial class KhrExternalMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_external_memory";
        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseExternalMemObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseExternalMemObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        public KhrExternalMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

