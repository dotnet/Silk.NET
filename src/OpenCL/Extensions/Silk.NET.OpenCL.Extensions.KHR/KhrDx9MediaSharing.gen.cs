// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_dx9_media_sharing")]
    public unsafe partial class KhrDx9MediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_dx9_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR")]
        public unsafe partial IntPtr CreateFromDX9MediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] void* surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromDX9MediaSurfaceKHR")]
        public partial IntPtr CreateFromDX9MediaSurface<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] Span<T0> surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR")]
        public unsafe partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireDX9MediaSurfacesKHR")]
        public partial int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR")]
        public unsafe partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseDX9MediaSurfacesKHR")]
        public partial int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR")]
        public unsafe partial int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromDX9MediaAdapterKHR")]
        public partial int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged;

        public unsafe IntPtr CreateFromDX9MediaSurface([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] void* surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromDX9MediaSurface(new IntPtr(context), flags, adapter_type, surface_info, plane, errcode_ret);
        }

        public unsafe IntPtr CreateFromDX9MediaSurface<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] Span<T0> surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateFromDX9MediaSurface(new IntPtr(context), flags, adapter_type, surface_info, plane, errcode_ret);
        }

        public unsafe int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireDX9MediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueAcquireDX9MediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireDX9MediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseDX9MediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int EnqueueReleaseDX9MediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseDX9MediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        public unsafe int GetDeviceIDsFromDX9MediaAdapter([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDsFromDX9MediaAdapter(new IntPtr(platform), num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, num_devices);
        }

        public unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceIDsFromDX9MediaAdapter(new IntPtr(platform), num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, num_devices);
        }

        public KhrDx9MediaSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

