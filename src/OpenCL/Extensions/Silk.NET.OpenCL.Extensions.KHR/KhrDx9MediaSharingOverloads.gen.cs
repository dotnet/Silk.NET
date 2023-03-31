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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrDx9MediaSharingOverloads
    {
        public static unsafe nint CreateFromDX9MediaSurface(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, surface_info, plane, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, errcode_ret);
        }

        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromDX9MediaSurface(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, surface_info, plane, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromDX9MediaSurface<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> surface_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromDX9MediaSurface(context, flags, adapter_type, out surface_info.GetPinnableReference(), plane, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseDX9MediaSurfaces(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseDX9MediaSurfaces(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, media_adapter_type, out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), media_adapters, media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromDX9MediaAdapter<T0>(this KhrDx9MediaSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> media_adapter_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> media_adapters, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint media_adapter_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromDX9MediaAdapter(platform, num_media_adapters, out media_adapter_type.GetPinnableReference(), out media_adapters.GetPinnableReference(), media_adapter_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

