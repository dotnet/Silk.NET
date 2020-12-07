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
    public static class KhrEglImageOverloads
    {
        public static unsafe IntPtr CreateFromEglimage(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromEglimage(context, egldisplay, eglimage, flags, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateFromEglimage(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromEglimage(context, egldisplay, eglimage, flags, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe IntPtr CreateFromEglimage(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr egldisplay, [Flow(FlowDirection.In)] IntPtr eglimage, [Flow(FlowDirection.In)] KHR flags, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromEglimage(context, egldisplay, eglimage, flags, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseEglobjects(this KhrEglImage thisApi, [Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseEglobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

