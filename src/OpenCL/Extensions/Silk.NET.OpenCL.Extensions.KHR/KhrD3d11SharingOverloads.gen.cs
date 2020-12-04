// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrD3d11SharingOverloads
    {
        public static unsafe IntPtr CreateFromD3D11Buffer(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, resource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), errcode_ret);
        }

        public static unsafe IntPtr CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromD3D11Texture2D(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        public static unsafe IntPtr CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromD3D11Texture3D(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] void* resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        public static unsafe IntPtr CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] void* d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

