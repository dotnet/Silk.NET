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
    [Extension("KHR_dx9_media_sharing")]
    public unsafe partial class KhrDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] void* surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] void* surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] out T0 surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromDX9MediaSurface<T0>([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] out T0 surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] out uint media_adapter_type, [Flow(FlowDirection.Out)] out T0 media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        public KhrDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

