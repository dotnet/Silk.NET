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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelProgramScopeHostPipeOverloads
    {
        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, out ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptr, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> @event) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, in ptr.GetPinnableReference(), size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

