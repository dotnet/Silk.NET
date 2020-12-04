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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelVaApiMediaSharingOverloads
    {
        public static unsafe IntPtr CreateFromVAApimediaSurface(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromVAApimediaSurface(context, flags, surface, plane, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseVAApimediaSurfaces(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, out media_adapter.GetPinnableReference(), media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, out media_adapter.GetPinnableReference(), media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, out media_adapter.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>(this IntelVaApiMediaSharing thisApi, [Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, out media_adapter.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

