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
    public static class KhrD3d10SharingOverloads
    {
        public static unsafe nint CreateFromD3D10Buffer<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Buffer(context, flags, resourceSpp, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Buffer<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Buffer(context, flags, resourceSpp, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Buffer<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Buffer(context, flags, resourceSpp, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D10Texture2D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture2D(context, flags, resourceSpp, subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Texture2D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture2D(context, flags, resourceSpp, subresource, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Texture2D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture2D(context, flags, resourceSpp, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D10Texture3D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture3D(context, flags, resourceSpp, subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Texture3D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture3D(context, flags, resourceSpp, subresource, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D10Texture3D<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.Out)] Span<T0> resource, [Flow(FlowDirection.In)] uint subresource, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* resourceSpp = resource)
                return thisApi.CreateFromD3D10Texture3D(context, flags, resourceSpp, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D10Objects(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D10Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] D3d10DeviceSource d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] D3d10DeviceSet d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] uint* num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d10DeviceSource, D3d10DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D10<T0>(this KhrD3d10Sharing thisApi, [Flow(FlowDirection.In)] nint platform, [Flow(FlowDirection.In)] uint d3d_device_source, [Flow(FlowDirection.Out)] Span<T0> d3d_object, [Flow(FlowDirection.In)] uint d3d_device_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : struct
        {
            // SpanOverloader
            fixed (void* d3d_objectSpp = d3d_object)
                return thisApi.GetDeviceIDsFromD3D10(platform, d3d_device_source, d3d_objectSpp, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

