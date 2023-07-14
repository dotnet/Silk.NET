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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    public static class ImgGenerateMipmapOverloads
    {
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MipmapFilterMode mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        [Obsolete("The \"ungrouped\" enums (IMG) are deprecated in favour of the \"grouped\" enums (MipmapFilterMode). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IMG mipmap_filter_mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

