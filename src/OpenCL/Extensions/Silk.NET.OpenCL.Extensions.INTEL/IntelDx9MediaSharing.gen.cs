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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_dx9_media_sharing")]
    public unsafe partial class IntelDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] nint sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] nint sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] nint sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromDX9MediaSurface([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] nint sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] Dx9DeviceSource dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] Dx9DeviceSet dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [Obsolete("The \"ungrouped\" enums (INTEL) are deprecated in favour of the \"grouped\" enums (Dx9DeviceSource, Dx9DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out nint devices, [Flow(FlowDirection.Out)] out uint num_devices);

        public IntelDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

