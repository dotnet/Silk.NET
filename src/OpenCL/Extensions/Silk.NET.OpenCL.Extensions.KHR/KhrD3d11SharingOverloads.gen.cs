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
    public static class KhrD3d11SharingOverloads
    {
        public static unsafe nint CreateFromD3D11Buffer(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, resource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Buffer(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, resource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Buffer<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Buffer(context, flags, out resource.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D11Texture2D(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        public static unsafe nint CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture2D(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture2D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture2D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D11Texture3D(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        public static unsafe nint CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture3D(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, resource, subresource, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, errcode_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromD3D11Texture3D<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> resource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint subresource, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateFromD3D11Texture3D(context, flags, out resource.GetPinnableReference(), subresource, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseD3D11Objects(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseD3D11Objects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSource d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3d11DeviceSet d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, d3d_object, d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (D3d11DeviceSource, D3d11DeviceSet). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetDeviceIDsFromD3D11<T0>(this KhrD3d11Sharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint platform, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> d3d_object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint d3d_device_set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetDeviceIDsFromD3D11(platform, d3d_device_source, out d3d_object.GetPinnableReference(), d3d_device_set, num_entries, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

