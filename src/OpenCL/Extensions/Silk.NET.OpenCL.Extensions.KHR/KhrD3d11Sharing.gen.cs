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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_d3d11_sharing")]
    public unsafe partial class KhrD3d11Sharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_d3d11_sharing";
        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR")]
        public unsafe partial IntPtr CreateFromD3D11Buffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11BufferKHR")]
        public partial IntPtr CreateFromD3D11Buffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR")]
        public unsafe partial IntPtr CreateFromD3D11Texture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture2DKHR")]
        public partial IntPtr CreateFromD3D11Texture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR")]
        public unsafe partial IntPtr CreateFromD3D11Texture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D11Texture3DKHR")]
        public partial IntPtr CreateFromD3D11Texture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public unsafe partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D11ObjectsKHR")]
        public partial int EnqueueAcquireD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public unsafe partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D11ObjectsKHR")]
        public partial int EnqueueReleaseD3D11Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in IntPtr mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in IntPtr event_wait_list, [Flow(FlowDirection.Out)] out IntPtr @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] out uint num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public unsafe partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D11KHR")]
        public partial int GetDeviceIDsFromD3D11<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] out T0 d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out IntPtr devices, [Flow(FlowDirection.Out)] out uint num_devices) where T0 : unmanaged;

        public KhrD3d11Sharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

