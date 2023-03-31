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
    public static class KhrGlSharingOverloads
    {
        public static unsafe nint CreateFromGlbuffer(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGlbuffer(context, flags, bufobj, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromGlbuffer(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGlbuffer(context, flags, bufobj, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromGlrenderbuffer(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGlrenderbuffer(context, flags, renderbuffer, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromGlrenderbuffer(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGlrenderbuffer(context, flags, renderbuffer, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromGltexture(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromGltexture(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromGltexture2D(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture2D(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromGltexture2D(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture2D(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateFromGltexture3D(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture3D(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe nint CreateFromGltexture3D(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int miplevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateFromGltexture3D(context, flags, target, miplevel, texture, out errcode_ret.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueAcquireGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueAcquireGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, mem_objects, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReleaseGlobjects(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReleaseGlobjects(command_queue, num_objects, in mem_objects.GetPinnableReference(), num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlContextInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(properties, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, param_value, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (ContextProperties, GlContextInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetGlcontextInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlcontextInfo(in properties.GetPinnableReference(), param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] GlObjectType* gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, gl_object_type, out gl_object_name.GetPinnableReference());
        }

        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<GlObjectType> gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, out gl_object_type.GetPinnableReference(), gl_object_name);
        }

        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<GlObjectType> gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, out gl_object_type.GetPinnableReference(), out gl_object_name.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, gl_object_type, out gl_object_name.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, out gl_object_type.GetPinnableReference(), gl_object_name);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGlobjectInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> gl_object_name)
        {
            // SpanOverloader
            return thisApi.GetGlobjectInfo(memobj, out gl_object_type.GetPinnableReference(), out gl_object_name.GetPinnableReference());
        }

        public static unsafe int GetGltextureInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlTextureInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetGltextureInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlTextureInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        public static unsafe int GetGltextureInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlTextureInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlTextureInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGltextureInfo(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret)
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, param_value, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlTextureInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGltextureInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (GlTextureInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetGltextureInfo<T0>(this KhrGlSharing thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGltextureInfo(memobj, param_name, param_value_size, out param_value.GetPinnableReference(), out param_value_size_ret.GetPinnableReference());
        }

    }
}

