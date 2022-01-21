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
    [Extension("KHR_d3d11_sharing")]
    public unsafe partial class KhrD3d11Sharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_d3d11_sharing";
        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Buffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Buffer([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Buffer<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromD3D11Buffer<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture2D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromD3D11Texture2D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture3D([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromD3D11Texture3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromD3D11Texture3D<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] out T0 resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        public KhrD3d11Sharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

