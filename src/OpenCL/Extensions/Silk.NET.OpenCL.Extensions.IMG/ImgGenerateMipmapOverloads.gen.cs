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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    public static class ImgGenerateMipmapOverloads
    {
        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] nuint* array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, array_region, in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] nuint* mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), mip_region, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueGenerateMipmap(this ImgGenerateMipmap thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint src_image, [Flow(FlowDirection.In)] nint dst_image, [Flow(FlowDirection.In)] IMG mipmap_filter_mode, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> array_region, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> mip_region, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueGenerateMipmap(command_queue, src_image, dst_image, mipmap_filter_mode, in array_region.GetPinnableReference(), in mip_region.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

