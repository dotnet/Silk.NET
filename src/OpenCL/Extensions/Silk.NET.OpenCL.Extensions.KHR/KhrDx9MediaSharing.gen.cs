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
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromDX9MediaSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromDX9MediaSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseDX9MediaSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR", Convention = CallingConvention.Winapi)]
        public partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        public KhrDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

