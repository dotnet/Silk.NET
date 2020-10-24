// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_dx9_media_sharing")]
    public unsafe partial class IntelDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL")]
        public unsafe partial IntPtr CreateFromDX9MediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] IntPtr sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceINTEL")]
        public partial IntPtr CreateFromDX9MediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] IntPtr sharedHandle, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public unsafe partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9ObjectsINTEL")]
        public partial int EnqueueAcquireDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public unsafe partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9ObjectsINTEL")]
        public partial int EnqueueReleaseDX9Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.Out)] out IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] void* dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] out T0 dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] out T0 dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public unsafe partial int GetDeviceIDsFromDX9<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] out T0 dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9INTEL")]
        public partial int GetDeviceIDsFromDX9<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint dx9_device_source, [Flow(FlowDirection.Out)] out T0 dx9_object, [Flow(FlowDirection.In)] uint dx9_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        public IntelDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

