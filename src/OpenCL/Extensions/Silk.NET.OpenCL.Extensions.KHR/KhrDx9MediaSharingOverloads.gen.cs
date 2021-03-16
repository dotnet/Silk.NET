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
    public static class KhrDx9MediaSharingOverloads
    {
        public static unsafe nint CreateFromDX9MediaSurface(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] void* surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, surface_info, plane, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] Span<T0> surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, errcode_ret);
        }

        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] uint adapter_type, [Flow(FlowDirection.Out)] Span<T0> surface_info, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] uint* media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint num_media_adapters, [Flow(FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapters, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

