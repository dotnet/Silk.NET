// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_d3d10_sharing")]
    public unsafe partial class KhrD3d10Sharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_d3d10_sharing";
        [NativeApi(EntryPoint = "clCreateFromD3D10BufferKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Buffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromD3D10Buffer(context, flags, resource, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D10BufferKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromD3D10Buffer([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromD3D10Buffer(context, flags, resource, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D10Texture2DKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromD3D10Texture2D(context, flags, resource, subresource, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D10Texture2DKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromD3D10Texture2D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromD3D10Texture2D(context, flags, resource, subresource, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D10Texture3DKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromD3D10Texture3D(context, flags, resource, subresource, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromD3D10Texture3DKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromD3D10Texture3D([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] IntPtr resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromD3D10Texture3D(context, flags, resource, subresource, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D10ObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireD3D10Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueAcquireD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireD3D10ObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueAcquireD3D10Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueAcquireD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D10ObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseD3D10Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReleaseD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseD3D10ObjectsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReleaseD3D10Objects([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueReleaseD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D10KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromD3D10([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
            => ImplGetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromD3D10KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetDeviceIDsFromD3D10<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
            => ImplGetDeviceIDsFromD3D10<T0>(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Buffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Buffer(new IntPtr(context), flags, new IntPtr(resource), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Buffer([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Buffer(new IntPtr(context), flags, new IntPtr(resource), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Texture2D(new IntPtr(context), flags, new IntPtr(resource), subresource, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture2D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Texture2D(new IntPtr(context), flags, new IntPtr(resource), subresource, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Texture3D(new IntPtr(context), flags, new IntPtr(resource), subresource, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromD3D10Texture3D([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] int resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromD3D10Texture3D(new IntPtr(context), flags, new IntPtr(resource), subresource, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireD3D10Objects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireD3D10Objects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireD3D10Objects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireD3D10Objects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseD3D10Objects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseD3D10Objects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseD3D10Objects([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseD3D10Objects(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromD3D10([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDsFromD3D10(new IntPtr(platform), d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromD3D10<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceIDsFromD3D10(new IntPtr(platform), d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, num_devices);
        }

        public KhrD3d10Sharing(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

