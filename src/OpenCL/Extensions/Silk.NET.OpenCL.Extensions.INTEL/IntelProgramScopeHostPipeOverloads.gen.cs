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
        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptrSpp, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueReadHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueReadHostPipe(command_queue, program, pipe_symbol, blocking_read, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptrSpp, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, in pipe_symbol.GetPinnableReference(), blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueWriteHostPipe<T0>(this IntelProgramScopeHostPipe thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ptrSpp = ptr)
                return thisApi.EnqueueWriteHostPipe(command_queue, program, pipe_symbol, blocking_write, ptrSpp, size, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

