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
    [Extension("KHR_egl_image")]
    public unsafe partial class KhrEglImage : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_egl_image";
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        public KhrEglImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

