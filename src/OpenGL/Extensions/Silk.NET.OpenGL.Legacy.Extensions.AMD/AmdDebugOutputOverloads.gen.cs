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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdDebugOutputOverloads
    {
        public static unsafe void DebugMessageCallback<T0>(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> userParam) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DebugMessageCallback(callback, out userParam.GetPinnableReference());
        }

        public static unsafe void DebugMessageEnable(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageEnable(category, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageEnable(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // SpanOverloader
            thisApi.DebugMessageEnable(category, severity, count, in ids.GetPinnableReference(), enabled);
        }

        public static unsafe void DebugMessageInsert(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(category, severity, id, length, in buf.GetPinnableReference());
        }

        public static unsafe void DebugMessageInsert(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // SpanOverloader
            thisApi.DebugMessageInsert(category, severity, id, length, in buf.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public static unsafe uint GetDebugMessageLog(this AmdDebugOutput thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // SpanOverloader
            return thisApi.GetDebugMessageLog(count, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

    }
}

